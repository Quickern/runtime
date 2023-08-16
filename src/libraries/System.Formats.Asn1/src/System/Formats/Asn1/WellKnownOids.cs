// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NETCOREAPP
namespace System.Formats.Asn1
{
    internal static class WellKnownOids
    {
        internal static string? GetValue(ReadOnlySpan<byte> contents)
        {
            return contents switch
            {
                [ 0x2A, 0x86, 0x48, 0xCE, 0x38, 0x04, 0x01, ] => "1.2.840.10040.4.1",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x38, 0x04, 0x03, ] => "1.2.840.10040.4.3",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x02, 0x01, ] => "1.2.840.10045.2.1",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x01, 0x01, ] => "1.2.840.10045.1.1",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x01, 0x02, ] => "1.2.840.10045.1.2",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x03, 0x01, 0x07, ] => "1.2.840.10045.3.1.7",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x01, ] => "1.2.840.10045.4.1",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x03, 0x02, ] => "1.2.840.10045.4.3.2",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x03, 0x03, ] => "1.2.840.10045.4.3.3",
                [ 0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x03, 0x04, ] => "1.2.840.10045.4.3.4",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, ] => "1.2.840.113549.1.1.1",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x05, ] => "1.2.840.113549.1.1.5",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x07, ] => "1.2.840.113549.1.1.7",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x08, ] => "1.2.840.113549.1.1.8",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x09, ] => "1.2.840.113549.1.1.9",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0A, ] => "1.2.840.113549.1.1.10",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0B, ] => "1.2.840.113549.1.1.11",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0C, ] => "1.2.840.113549.1.1.12",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0D, ] => "1.2.840.113549.1.1.13",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x03, ] => "1.2.840.113549.1.5.3",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0A, ] => "1.2.840.113549.1.5.10",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0B, ] => "1.2.840.113549.1.5.11",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0C, ] => "1.2.840.113549.1.5.12",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0D, ] => "1.2.840.113549.1.5.13",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x01, ] => "1.2.840.113549.1.7.1",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x02, ] => "1.2.840.113549.1.7.2",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x03, ] => "1.2.840.113549.1.7.3",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x06, ] => "1.2.840.113549.1.7.6",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x01, ] => "1.2.840.113549.1.9.1",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x03, ] => "1.2.840.113549.1.9.3",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x04, ] => "1.2.840.113549.1.9.4",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x05, ] => "1.2.840.113549.1.9.5",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x06, ] => "1.2.840.113549.1.9.6",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x07, ] => "1.2.840.113549.1.9.7",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x0E, ] => "1.2.840.113549.1.9.14",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x0F, ] => "1.2.840.113549.1.9.15",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x01, 0x04, ] => "1.2.840.113549.1.9.16.1.4",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x02, 0x0C, ] => "1.2.840.113549.1.9.16.2.12",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x02, 0x0E, ] => "1.2.840.113549.1.9.16.2.14",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x02, 0x2F, ] => "1.2.840.113549.1.9.16.2.47",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x14, ] => "1.2.840.113549.1.9.20",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x15, ] => "1.2.840.113549.1.9.21",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x16, 0x01, ] => "1.2.840.113549.1.9.22.1",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x01, 0x03, ] => "1.2.840.113549.1.12.1.3",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x01, 0x05, ] => "1.2.840.113549.1.12.1.5",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x01, 0x06, ] => "1.2.840.113549.1.12.1.6",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x01, ] => "1.2.840.113549.1.12.10.1.1",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x02, ] => "1.2.840.113549.1.12.10.1.2",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x03, ] => "1.2.840.113549.1.12.10.1.3",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x05, ] => "1.2.840.113549.1.12.10.1.5",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x06, ] => "1.2.840.113549.1.12.10.1.6",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x05, ] => "1.2.840.113549.2.5",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x07, ] => "1.2.840.113549.2.7",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x09, ] => "1.2.840.113549.2.9",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x0A, ] => "1.2.840.113549.2.10",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x0B, ] => "1.2.840.113549.2.11",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x03, 0x02, ] => "1.2.840.113549.3.2",
                [ 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x03, 0x07, ] => "1.2.840.113549.3.7",
                [ 0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x11, 0x01, ] => "1.3.6.1.4.1.311.17.1",
                [ 0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x11, 0x03, 0x14, ] => "1.3.6.1.4.1.311.17.3.20",
                [ 0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x14, 0x02, 0x03, ] => "1.3.6.1.4.1.311.20.2.3",
                [ 0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x58, 0x02, 0x01, ] => "1.3.6.1.4.1.311.88.2.1",
                [ 0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x58, 0x02, 0x02, ] => "1.3.6.1.4.1.311.88.2.2",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x01, ] => "1.3.6.1.5.5.7.3.1",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x02, ] => "1.3.6.1.5.5.7.3.2",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x03, ] => "1.3.6.1.5.5.7.3.3",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x04, ] => "1.3.6.1.5.5.7.3.4",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x08, ] => "1.3.6.1.5.5.7.3.8",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x09, ] => "1.3.6.1.5.5.7.3.9",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x06, 0x02, ] => "1.3.6.1.5.5.7.6.2",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x30, 0x01, ] => "1.3.6.1.5.5.7.48.1",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x30, 0x01, 0x02, ] => "1.3.6.1.5.5.7.48.1.2",
                [ 0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x30, 0x02, ] => "1.3.6.1.5.5.7.48.2",
                [ 0x2B, 0x0E, 0x03, 0x02, 0x1A, ] => "1.3.14.3.2.26",
                [ 0x2B, 0x0E, 0x03, 0x02, 0x07, ] => "1.3.14.3.2.7",
                [ 0x2B, 0x81, 0x04, 0x00, 0x22, ] => "1.3.132.0.34",
                [ 0x2B, 0x81, 0x04, 0x00, 0x23, ] => "1.3.132.0.35",
                [ 0x55, 0x04, 0x03, ] => "2.5.4.3",
                [ 0x55, 0x04, 0x05, ] => "2.5.4.5",
                [ 0x55, 0x04, 0x06, ] => "2.5.4.6",
                [ 0x55, 0x04, 0x07, ] => "2.5.4.7",
                [ 0x55, 0x04, 0x08, ] => "2.5.4.8",
                [ 0x55, 0x04, 0x0A, ] => "2.5.4.10",
                [ 0x55, 0x04, 0x0B, ] => "2.5.4.11",
                [ 0x55, 0x04, 0x61, ] => "2.5.4.97",
                [ 0x55, 0x1D, 0x0E, ] => "2.5.29.14",
                [ 0x55, 0x1D, 0x0F, ] => "2.5.29.15",
                [ 0x55, 0x1D, 0x11, ] => "2.5.29.17",
                [ 0x55, 0x1D, 0x13, ] => "2.5.29.19",
                [ 0x55, 0x1D, 0x14, ] => "2.5.29.20",
                [ 0x55, 0x1D, 0x23, ] => "2.5.29.35",
                [ 0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x01, 0x02, ] => "2.16.840.1.101.3.4.1.2",
                [ 0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x01, 0x16, ] => "2.16.840.1.101.3.4.1.22",
                [ 0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x01, 0x2A, ] => "2.16.840.1.101.3.4.1.42",
                [ 0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x01, ] => "2.16.840.1.101.3.4.2.1",
                [ 0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x02, ] => "2.16.840.1.101.3.4.2.2",
                [ 0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x03, ] => "2.16.840.1.101.3.4.2.3",
                [ 0x67, 0x81, 0x0C, 0x01, 0x02, 0x01, ] => "2.23.140.1.2.1",
                [ 0x67, 0x81, 0x0C, 0x01, 0x02, 0x02, ] => "2.23.140.1.2.2",
               _ => null,
            };
        }

        internal static ReadOnlySpan<byte> GetContents(ReadOnlySpan<char> value)
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x2A, 0x86, 0x48, 0xCE, 0x38, 0x04, 0x01, // DSA
                0x2A, 0x86, 0x48, 0xCE, 0x38, 0x04, 0x03, // DSAWithSha1
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x02, 0x01, // EC
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x01, 0x01, // EcPrimeField
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x01, 0x02, // EcChar2Field
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x03, 0x01, 0x07, // Secp256r1
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x01, // ECDSAWithSha1
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x03, 0x02, // ECDSAWithSha256
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x03, 0x03, // ECDSAWithSha384
                0x2A, 0x86, 0x48, 0xCE, 0x3D, 0x04, 0x03, 0x04, // ECDSAWithSha512
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, // RSA
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x05, // RSAWithSha1
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x07, // RSAOAEP
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x08, // MGF1
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x09, // OaepPSpecified
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0A, // RSAPSS
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0B, // RSAWithSha256
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0C, // RSAWithSha384
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x0D, // RSAWithSha512
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x03, // PbeWithMD5AndDESCBC
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0A, // PbeWithSha1AndDESCBC
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0B, // PbeWithSha1AndRC2CBC
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0C, // Pbkdf2
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x05, 0x0D, // PasswordBasedEncryptionScheme2
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x01, // Pkcs7Data
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x02, // Pkcs7SignedData
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x03, // Pkcs7EnvelopedData
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x07, 0x06, // Pkcs7EncryptedData
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x01, // Pkcs9EmailAddress
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x03, // Pkcs9ContentType
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x04, // Pkcs9MessageDigest
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x05, // Pkcs9SigningTime
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x06, // Pkcs9CounterSigner
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x07, // Pkcs9Challenge
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x0E, // Pkcs9ExtensionRequest
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x0F, // Pkcs9SMimeCapabilities
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x01, 0x04, // TstInfo
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x02, 0x0C, // SigningCertificateAttr
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x02, 0x0E, // SignatureTimeStampAttr
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x10, 0x02, 0x2F, // SigningCertificateV2Attr
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x14, // Pkcs9FriendlyName
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x15, // LocalKeyId
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x09, 0x16, 0x01, // Pkcs12X509CertType
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x01, 0x03, // Pkcs12TripleDes
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x01, 0x05, // Pkcs12Rc2Cbc128
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x01, 0x06, // Pkcs12Rc2Cbc40
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x01, // Pkcs12KeyBag
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x02, // Pkcs12ShroudedKeyBag
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x03, // Pkcs12CertBag
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x05, // Pkcs12SecretBag
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x0C, 0x0A, 0x01, 0x06, // Pkcs12SafeContentsBag
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x05, // MD5
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x07, // HMACSHA1
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x09, // HMACSHA256
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x0A, // HMACSHA384
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x02, 0x0B, // HMACSHA512
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x03, 0x02, // RC2CBC
                0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x03, 0x07, // TripleDESCBC
                0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x11, 0x01, // Pkcs12KeyProviderName
                0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x11, 0x03, 0x14, // KeyIdentifier
                0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x14, 0x02, 0x03, // UserPrincipalName
                0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x58, 0x02, 0x01, // DocumentNameAttr
                0x2B, 0x06, 0x01, 0x04, 0x01, 0x82, 0x37, 0x58, 0x02, 0x02, // DocumentDescriptionAttr
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x01, // KeyPurposeTlsServer
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x02, // KeyPurposeTlsClient
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x03, // KeyPurposeCodeSign
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x04, // KeyPurposeEmailProtection
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x08, // KeyPurposeTimestamping
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x03, 0x09, // KeyPurposeOcspSigner
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x06, 0x02, // Pkcs7NoSignature
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x30, 0x01, // OCSP
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x30, 0x01, 0x02, // OcspNonce
                0x2B, 0x06, 0x01, 0x05, 0x05, 0x07, 0x30, 0x02, // CAIssuers
                0x2B, 0x0E, 0x03, 0x02, 0x1A, // SHA1
                0x2B, 0x0E, 0x03, 0x02, 0x07, // DES
                0x2B, 0x81, 0x04, 0x00, 0x22, // Secp384r1
                0x2B, 0x81, 0x04, 0x00, 0x23, // Secp521r1
                0x55, 0x04, 0x03, // CommonName
                0x55, 0x04, 0x05, // SerialNumber
                0x55, 0x04, 0x06, // CountryOrRegionName
                0x55, 0x04, 0x07, // Locality
                0x55, 0x04, 0x08, // StateOrProvinceName
                0x55, 0x04, 0x0A, // OrganizationName
                0x55, 0x04, 0x0B, // OrganizationalUnit
                0x55, 0x04, 0x61, // OrganizationIdentifier
                0x55, 0x1D, 0x0E, // SubjectKeyIdentifier
                0x55, 0x1D, 0x0F, // KeyUsage
                0x55, 0x1D, 0x11, // SubjectAlternativeName
                0x55, 0x1D, 0x13, // BasicConstraints
                0x55, 0x1D, 0x14, // CrlNumber
                0x55, 0x1D, 0x23, // AuthorityKeyIdentifier
                0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x01, 0x02, // Aes128Cbc
                0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x01, 0x16, // Aes192Cbc
                0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x01, 0x2A, // Aes256Cbc
                0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x01, // Sha256
                0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x02, // Sha384
                0x60, 0x86, 0x48, 0x01, 0x65, 0x03, 0x04, 0x02, 0x03, // Sha512
                0x67, 0x81, 0x0C, 0x01, 0x02, 0x01, // CabForumDV
                0x67, 0x81, 0x0C, 0x01, 0x02, 0x02, // CabForumOV
            };

            return value switch
            {
                "1.2.840.10040.4.1" => data.Slice(0, 7), // DSA
                "1.2.840.10040.4.3" => data.Slice(7, 7), // DSAWithSha1
                "1.2.840.10045.2.1" => data.Slice(14, 7), // EC
                "1.2.840.10045.1.1" => data.Slice(21, 7), // EcPrimeField
                "1.2.840.10045.1.2" => data.Slice(28, 7), // EcChar2Field
                "1.2.840.10045.3.1.7" => data.Slice(35, 8), // Secp256r1
                "1.2.840.10045.4.1" => data.Slice(43, 7), // ECDSAWithSha1
                "1.2.840.10045.4.3.2" => data.Slice(50, 8), // ECDSAWithSha256
                "1.2.840.10045.4.3.3" => data.Slice(58, 8), // ECDSAWithSha384
                "1.2.840.10045.4.3.4" => data.Slice(66, 8), // ECDSAWithSha512
                "1.2.840.113549.1.1.1" => data.Slice(74, 9), // RSA
                "1.2.840.113549.1.1.5" => data.Slice(83, 9), // RSAWithSha1
                "1.2.840.113549.1.1.7" => data.Slice(92, 9), // RSAOAEP
                "1.2.840.113549.1.1.8" => data.Slice(101, 9), // MGF1
                "1.2.840.113549.1.1.9" => data.Slice(110, 9), // OaepPSpecified
                "1.2.840.113549.1.1.10" => data.Slice(119, 9), // RSAPSS
                "1.2.840.113549.1.1.11" => data.Slice(128, 9), // RSAWithSha256
                "1.2.840.113549.1.1.12" => data.Slice(137, 9), // RSAWithSha384
                "1.2.840.113549.1.1.13" => data.Slice(146, 9), // RSAWithSha512
                "1.2.840.113549.1.5.3" => data.Slice(155, 9), // PbeWithMD5AndDESCBC
                "1.2.840.113549.1.5.10" => data.Slice(164, 9), // PbeWithSha1AndDESCBC
                "1.2.840.113549.1.5.11" => data.Slice(173, 9), // PbeWithSha1AndRC2CBC
                "1.2.840.113549.1.5.12" => data.Slice(182, 9), // Pbkdf2
                "1.2.840.113549.1.5.13" => data.Slice(191, 9), // PasswordBasedEncryptionScheme2
                "1.2.840.113549.1.7.1" => data.Slice(200, 9), // Pkcs7Data
                "1.2.840.113549.1.7.2" => data.Slice(209, 9), // Pkcs7SignedData
                "1.2.840.113549.1.7.3" => data.Slice(218, 9), // Pkcs7EnvelopedData
                "1.2.840.113549.1.7.6" => data.Slice(227, 9), // Pkcs7EncryptedData
                "1.2.840.113549.1.9.1" => data.Slice(236, 9), // Pkcs9EmailAddress
                "1.2.840.113549.1.9.3" => data.Slice(245, 9), // Pkcs9ContentType
                "1.2.840.113549.1.9.4" => data.Slice(254, 9), // Pkcs9MessageDigest
                "1.2.840.113549.1.9.5" => data.Slice(263, 9), // Pkcs9SigningTime
                "1.2.840.113549.1.9.6" => data.Slice(272, 9), // Pkcs9CounterSigner
                "1.2.840.113549.1.9.7" => data.Slice(281, 9), // Pkcs9Challenge
                "1.2.840.113549.1.9.14" => data.Slice(290, 9), // Pkcs9ExtensionRequest
                "1.2.840.113549.1.9.15" => data.Slice(299, 9), // Pkcs9SMimeCapabilities
                "1.2.840.113549.1.9.16.1.4" => data.Slice(308, 11), // TstInfo
                "1.2.840.113549.1.9.16.2.12" => data.Slice(319, 11), // SigningCertificateAttr
                "1.2.840.113549.1.9.16.2.14" => data.Slice(330, 11), // SignatureTimeStampAttr
                "1.2.840.113549.1.9.16.2.47" => data.Slice(341, 11), // SigningCertificateV2Attr
                "1.2.840.113549.1.9.20" => data.Slice(352, 9), // Pkcs9FriendlyName
                "1.2.840.113549.1.9.21" => data.Slice(361, 9), // LocalKeyId
                "1.2.840.113549.1.9.22.1" => data.Slice(370, 10), // Pkcs12X509CertType
                "1.2.840.113549.1.12.1.3" => data.Slice(380, 10), // Pkcs12TripleDes
                "1.2.840.113549.1.12.1.5" => data.Slice(390, 10), // Pkcs12Rc2Cbc128
                "1.2.840.113549.1.12.1.6" => data.Slice(400, 10), // Pkcs12Rc2Cbc40
                "1.2.840.113549.1.12.10.1.1" => data.Slice(410, 11), // Pkcs12KeyBag
                "1.2.840.113549.1.12.10.1.2" => data.Slice(421, 11), // Pkcs12ShroudedKeyBag
                "1.2.840.113549.1.12.10.1.3" => data.Slice(432, 11), // Pkcs12CertBag
                "1.2.840.113549.1.12.10.1.5" => data.Slice(443, 11), // Pkcs12SecretBag
                "1.2.840.113549.1.12.10.1.6" => data.Slice(454, 11), // Pkcs12SafeContentsBag
                "1.2.840.113549.2.5" => data.Slice(465, 8), // MD5
                "1.2.840.113549.2.7" => data.Slice(473, 8), // HMACSHA1
                "1.2.840.113549.2.9" => data.Slice(481, 8), // HMACSHA256
                "1.2.840.113549.2.10" => data.Slice(489, 8), // HMACSHA384
                "1.2.840.113549.2.11" => data.Slice(497, 8), // HMACSHA512
                "1.2.840.113549.3.2" => data.Slice(505, 8), // RC2CBC
                "1.2.840.113549.3.7" => data.Slice(513, 8), // TripleDESCBC
                "1.3.6.1.4.1.311.17.1" => data.Slice(521, 9), // Pkcs12KeyProviderName
                "1.3.6.1.4.1.311.17.3.20" => data.Slice(530, 10), // KeyIdentifier
                "1.3.6.1.4.1.311.20.2.3" => data.Slice(540, 10), // UserPrincipalName
                "1.3.6.1.4.1.311.88.2.1" => data.Slice(550, 10), // DocumentNameAttr
                "1.3.6.1.4.1.311.88.2.2" => data.Slice(560, 10), // DocumentDescriptionAttr
                "1.3.6.1.5.5.7.3.1" => data.Slice(570, 8), // KeyPurposeTlsServer
                "1.3.6.1.5.5.7.3.2" => data.Slice(578, 8), // KeyPurposeTlsClient
                "1.3.6.1.5.5.7.3.3" => data.Slice(586, 8), // KeyPurposeCodeSign
                "1.3.6.1.5.5.7.3.4" => data.Slice(594, 8), // KeyPurposeEmailProtection
                "1.3.6.1.5.5.7.3.8" => data.Slice(602, 8), // KeyPurposeTimestamping
                "1.3.6.1.5.5.7.3.9" => data.Slice(610, 8), // KeyPurposeOcspSigner
                "1.3.6.1.5.5.7.6.2" => data.Slice(618, 8), // Pkcs7NoSignature
                "1.3.6.1.5.5.7.48.1" => data.Slice(626, 8), // OCSP
                "1.3.6.1.5.5.7.48.1.2" => data.Slice(634, 9), // OcspNonce
                "1.3.6.1.5.5.7.48.2" => data.Slice(643, 8), // CAIssuers
                "1.3.14.3.2.26" => data.Slice(651, 5), // SHA1
                "1.3.14.3.2.7" => data.Slice(656, 5), // DES
                "1.3.132.0.34" => data.Slice(661, 5), // Secp384r1
                "1.3.132.0.35" => data.Slice(666, 5), // Secp521r1
                "2.5.4.3" => data.Slice(671, 3), // CommonName
                "2.5.4.5" => data.Slice(674, 3), // SerialNumber
                "2.5.4.6" => data.Slice(677, 3), // CountryOrRegionName
                "2.5.4.7" => data.Slice(680, 3), // Locality
                "2.5.4.8" => data.Slice(683, 3), // StateOrProvinceName
                "2.5.4.10" => data.Slice(686, 3), // OrganizationName
                "2.5.4.11" => data.Slice(689, 3), // OrganizationalUnit
                "2.5.4.97" => data.Slice(692, 3), // OrganizationIdentifier
                "2.5.29.14" => data.Slice(695, 3), // SubjectKeyIdentifier
                "2.5.29.15" => data.Slice(698, 3), // KeyUsage
                "2.5.29.17" => data.Slice(701, 3), // SubjectAlternativeName
                "2.5.29.19" => data.Slice(704, 3), // BasicConstraints
                "2.5.29.20" => data.Slice(707, 3), // CrlNumber
                "2.5.29.35" => data.Slice(710, 3), // AuthorityKeyIdentifier
                "2.16.840.1.101.3.4.1.2" => data.Slice(713, 9), // Aes128Cbc
                "2.16.840.1.101.3.4.1.22" => data.Slice(722, 9), // Aes192Cbc
                "2.16.840.1.101.3.4.1.42" => data.Slice(731, 9), // Aes256Cbc
                "2.16.840.1.101.3.4.2.1" => data.Slice(740, 9), // Sha256
                "2.16.840.1.101.3.4.2.2" => data.Slice(749, 9), // Sha384
                "2.16.840.1.101.3.4.2.3" => data.Slice(758, 9), // Sha512
                "2.23.140.1.2.1" => data.Slice(767, 6), // CabForumDV
                "2.23.140.1.2.2" => data.Slice(773, 6), // CabForumOV
                _ => ReadOnlySpan<byte>.Empty
            };
        }
    }
}
#endif