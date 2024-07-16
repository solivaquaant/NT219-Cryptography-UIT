//Đoạn code 1
void convertMontgomeryToWeierstrass(const Integer &p, const Integer &A, const Integer &B,
                                    Integer &a, Integer &b)
{
    Integer A_squared = A.Squared() % p;
    Integer B_squared = B.Squared() % p;
    Integer B_cubed = B * B_squared % p;
    ModularArithmetic ma(p);

    Integer three_B_squared = 3 * B_squared % p;
    Integer twenty_seven_B_cubed = 27 * B_cubed % p;

    a = (3 - A_squared) * ma.MultiplicativeInverse(three_B_squared) % p;
    b = (2 * A * A_squared - 9 * A) * ma.MultiplicativeInverse(twenty_seven_B_cubed) % p;
}
//Đoạn code 2
void convertBasePointMontgomeryToWeierstrass(const Integer &p, const Integer &A, const Integer &B,
                                             const Integer &u, const Integer &v,
                                             Integer &x, Integer &y)
{
    Integer B_inv = B.InverseMod(p);
    Integer A_div_3B = A * B_inv / 3 % p;
    x = (u * B_inv + A_div_3B) % p;
    y = v * B_inv % p;
}
//Đoạn code 3:
void saveCurveParameters(const std::string &curveName, const std::string &filename)
{
    std::ofstream outFile(filename);
    if (!outFile)
    {
        throw std::runtime_error("Unable to open file for writing curve parameters");
    }

    Integer p, A, B, gx, gy, n, h;
    std::string curveType;
    if (curveName == "Curve383187")
    {
        p = Integer("0x7FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF45");
        A = Integer("0x1f82fe");
        B = Integer("0x01");
        gx = Integer("0x0c");
        gy = Integer("0x1ec7ed04aaf834af310e304b2da0f328e7c165f0e8988abd3992861290f617aa1f1b2e7d0b6e332e969991b62555e77e");
        n = Integer("0x10000000000000000000000000000000000000000000000006C79673AC36BA6E7A32576F7B1B249E46BBC225BE9071D7");
        h = Integer("0x08");
        curveType = "Montgomery";
    }
    else if (curveName == "M-511")
    {
        p = Integer("0x7FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFED");
        A = Integer("0x00");
        B = Integer("0x01");
        gx = Integer("0x00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003");
        gy = Integer("0x06A64AFA883DFDB32214AB2A64F6D9A5B27967A7AEB3A76B33DFD6D1C28453994B1BDEC04ECA3E0F257858DBBC6FD32779C19393F7BC3A999562A09DDB9DF5B6");
        n = Integer("0x7FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF7C");
        h = Integer("0x04");
        curveType = "Montgomery";
    }
    else if (curveName == "Curve25519") // M-255
    {
        p = Integer("0x7FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFED");
        A = Integer("0x76D06");
        B = Integer("0x01");
        gx = Integer("0x9");
        gy = Integer("0x20AE19A1B8A086B4E01EDD2C7748D14C923D4DF4A64A4E125DCDA942D59D5B24");
        n = Integer("0x1000000000000000000000000000000014DEF9DEA2F79CD65812631A5CF5D3ED");
        h = Integer("0x08");
        curveType = "Montgomery";
    }
    else
    {
        throw std::invalid_argument("Unsupported curve name.");
    }

    Integer a, b, Gx, Gy;
    if (curveType == "Montgomery") // Convertion
    {
        convertMontgomeryToWeierstrass(p, A, B, a, b);
        convertBasePointMontgomeryToWeierstrass(p, A, B, gx, gy, Gx, Gy);
    }
    else
    {
        a = A;
        b = B;
        Gx = gx;
        Gy = gy;
    }

    // Print parameters for debugging
    std::cout << "Prime number p = " << std::hex << p << std::endl;
    std::cout << "Coefficient a = " << std::hex << a << std::endl;
    std::cout << "Coefficient b = " << std::hex << b << std::endl;
    std::cout << "Base point G.x = " << std::hex << Gx << std::endl;
    std::cout << "Base point G.y = " << std::hex << Gy << std::endl;
    std::cout << "Subgroup order n = " << std::hex << n << std::endl;
    std::cout << "Cofactor h = " << std::hex << h << std::dec << std::endl;

    // Encode parameters in ASN.1 DER format
    ByteQueue derQueue;
    DERSequenceEncoder seq(derQueue);
    p.DEREncode(seq);
    a.DEREncode(seq);
    b.DEREncode(seq);
    Gx.DEREncode(seq);
    Gy.DEREncode(seq);
    n.DEREncode(seq);
    h.DEREncode(seq);
    seq.MessageEnd();

    // Convert DER to Base64
    std::string encoded;
    Base64Encoder encoder(new StringSink(encoded), true, 64);
    derQueue.CopyTo(encoder);
    encoder.MessageEnd();

    // Write to PEM file
    outFile << "-----BEGIN EC PARAMETERS-----\n";
    outFile << encoded;
    outFile << "-----END EC PARAMETERS-----";
    outFile.close();
    std::cout << "The cure parameters have saved to " << filename << std::endl;
}
//Đoạn code 4:
 // Construct the curve
    ECP curve(p, a, b);
    ECP::Point G(Gx, Gy);
 
    // Initialize the curve parameters
    DL_GroupParameters_EC<ECP> params;
    params.Initialize(curve, G, n, h);