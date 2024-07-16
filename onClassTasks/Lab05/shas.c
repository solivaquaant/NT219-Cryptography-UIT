#include <openssl/evp.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#ifdef BUILD_DLL
#define EXPORT __attribute__((visibility("default")))
#else
#define EXPORT
#endif

// Có thể chạy cho đời 2 và đời 3
//  always use char for not confict
EXPORT void hashes(const char *algo, const char *input_filename, const char *output_filename);

void hashes(const char *algo, const char *input_filename, const char *output_filename)
{
    // Create and initialize the context
    EVP_MD_CTX *hashes;
    const EVP_MD *md = EVP_get_digestbyname(algo); // thuat toan dau vao

    // Input file
    FILE *f_in = fopen(input_filename, "rb");
    if (!f_in)
    {
        perror("Failed to open input file");
        exit(EXIT_FAILURE);
    }
    // Output file
    FILE *f_out = fopen(output_filename, "w");
    if (!f_out)
    {
        perror("Failed to open output file");
        fclose(f_in);
        exit(EXIT_FAILURE);
    }
    // Check input arguments algo (from input)
    if (!md)
    {
        fprintf(stderr, "Unknown message digest %s\n", algo);
        fclose(f_in);
        fclose(f_out);
        exit(EXIT_FAILURE);
    }

    // Settig hashes function (create instance)
    // INIT
    hashes = EVP_MD_CTX_new();
    EVP_DigestInit_ex(hashes, md, NULL);

    // Read file from input file and update the digest
    // UPDATE
    unsigned char buffer[4096]; // maybe larger khó chịu
    size_t read_bytes;
    while ((read_bytes = fread(buffer, 1, sizeof(buffer), f_in)) != 0)
    {
        EVP_DigestUpdate(hashes, buffer, read_bytes); // set input for hash function
    }

    // Finalize the digest
    // FINAl
    unsigned char md_value[EVP_MAX_MD_SIZE]; // max output: 512, có thể là biến input
    unsigned int md_len;
    EVP_DigestFinal_ex(hashes, md_value, &md_len); // set actual output length
    EVP_MD_CTX_free(hashes);                       // close hashes

    // Write the digest to the output file (try bio instead)
    for (unsigned int i = 0; i < md_len; i++)
    {
        fprintf(f_out, "%02x", md_value[i]);
    }
    fprintf(f_out, "\n"); // write output md_value to file
    // Close files, if not can leak memory
    fclose(f_in);
    fclose(f_out);
}

int main(int argc, char **argv)
{
    if (argc != 4)
    { // C# should be 3
        fprintf(stderr, "Usage: %s <hash-algorithm> <input-file> <output-file>\n", argv[0]);
        exit(EXIT_FAILURE);
    }

    const char *algo = argv[1];
    const char *input_filename = argv[2];
    const char *output_filename = argv[3];
    hashes(algo, input_filename, output_filename);
    printf("Hashed saved to %s", output_filename);
    return 0;
}