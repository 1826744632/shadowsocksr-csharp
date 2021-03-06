﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shadowsocks.Model;

namespace test
{
    [TestClass]
    public class ServerTest
    {
        [TestMethod]
        public void TestServerFromSSR()
        {
            Server server = new Server();
            string nornameCase = "ssr://MTI3LjAuMC4xOjEyMzQ6YXV0aF9hZXMxMjhfbWQ1OmFlcy0xMjgtY2ZiOnRsczEuMl90aWNrZXRfYXV0aDpZV0ZoWW1KaS8_b2Jmc3BhcmFtPVluSmxZV3QzWVRFeExtMXZaUQ";

            server.ServerFromSSR(nornameCase, "");

            Assert.AreEqual<string>(server.server, "127.0.0.1");
            Assert.AreEqual<int>(server.server_port, 1234);
            Assert.AreEqual<string>(server.protocol, "auth_aes128_md5");
            Assert.AreEqual<string>(server.method, "aes-128-cfb");
            Assert.AreEqual<string>(server.obfs, "tls1.2_ticket_auth");
            Assert.AreEqual<string>(server.obfsparam, "breakwa11.moe");
            Assert.AreEqual<string>(server.password, "aaabbb");

            server = new Server();
            string normalCaseWithRemark = "ssr://MTI3LjAuMC4xOjEyMzQ6YXV0aF9hZXMxMjhfbWQ1OmFlcy0xMjgtY2ZiOnRsczEuMl90aWNrZXRfYXV0aDpZV0ZoWW1KaS8_b2Jmc3BhcmFtPVluSmxZV3QzWVRFeExtMXZaUSZyZW1hcmtzPTVyV0w2Sy1WNUxpdDVwYUg";

            server.ServerFromSSR(normalCaseWithRemark, "firewallAirport");

            Assert.AreEqual<string>(server.server, "127.0.0.1");
            Assert.AreEqual<int>(server.server_port, 1234);
            Assert.AreEqual<string>(server.protocol, "auth_aes128_md5");
            Assert.AreEqual<string>(server.method, "aes-128-cfb");
            Assert.AreEqual<string>(server.obfs, "tls1.2_ticket_auth");
            Assert.AreEqual<string>(server.obfsparam, "breakwa11.moe");
            Assert.AreEqual<string>(server.password, "aaabbb");

            Assert.AreEqual<string>(server.remarks, "测试中文");
            Assert.AreEqual<string>(server.group, "firewallAirport");
        }
    }
}
