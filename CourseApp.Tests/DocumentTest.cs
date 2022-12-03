namespace CourseApp.Tests
{
    using Xunit;

    public class DocumentTest
    {
        [Fact]
        public void OfficialTest()
        {
            var officDoc = new Official("Official memo π12", "Official memo", 451);
            Assert.Equal("Official memo π12", officDoc.Name);
            Assert.Equal("Official memo", officDoc.Type);
            Assert.Equal(451, officDoc.Size);
        }

        [Fact]
        public void ProtocolTest()
        {
            var protDoc = new Protocol("Protocol π22122", "Protocol", 366);
            Assert.Equal("Protocol π22122", protDoc.Name);
            Assert.Equal("Protocol", protDoc.Type);
            Assert.Equal(366, protDoc.Size);
        }

        [Fact]
        public void AnalyticalTest()
        {
            var anDoc = new Analytical("Special conclusion", "—onclusion", 215);
            Assert.Equal("Special conclusion", anDoc.Name);
            Assert.Equal("—onclusion", anDoc.Type);
            Assert.Equal(215, anDoc.Size);
        }

        [Fact]
        public void OfficialDocumentSizeTest()
        {
            var officDoc = new Official("Official memo π12", "Official memo", 451);
            var result = officDoc.DocumentSize();
            Assert.Equal("451 Ã· ", result);
        }

        [Fact]
        public void ProtocolDocumentSizeTest()
        {
            var protDoc = new Protocol("Protocol π22122", "Protocol", 366);
            var result = protDoc.DocumentSize();
            Assert.Equal("366 Ã· ", result);
        }

        [Fact]
        public void AnalyticalDocumentSizeTest()
        {
            var anDoc = new Analytical("Special conclusion", "—onclusion", 215);
            var result = anDoc.DocumentSize();
            Assert.Equal("215 Ã· ", result);
        }

        [Fact]
        public void OfficialWayTest()
        {
            var officDoc = new Official("Official memo π12", "Official memo", 451);
            var result = officDoc.Way();
            Assert.Equal("C:/files", result);
        }

        [Fact]
        public void ProtocolWayTest()
        {
            var protDoc = new Protocol("Protocol π22122", "Protocol", 366);
            var result = protDoc.Way();
            Assert.Equal("D:/files/documents", result);
        }

        [Fact]
        public void AnalyticalWayTest()
        {
            var anDoc = new Analytical("Special conclusion", "—onclusion", 215);
            var result = anDoc.Way();
            Assert.Equal("C:/work/documents", result);
        }

        [Fact]
        public void OfficialNameOfElTest()
        {
            var officDoc = new Official("Official memo π12", "Official memo", 451);
            var result = officDoc.NameOfEl();
            Assert.Equal("OfficialDocument: ", result);
        }

        [Fact]
        public void ProtocolNameOfElTest()
        {
            var protDoc = new Protocol("Protocol π22122", "Protocol", 366);
            var result = protDoc.NameOfEl();
            Assert.Equal("ProtocolDocument: ", result);
        }

        [Fact]
        public void AnalyticalNameOfElTest()
        {
            var anDoc = new Analytical("Special conclusion", "—onclusion", 215);
            var result = anDoc.NameOfEl();
            Assert.Equal("AnalyticalDocument: ", result);
        }

        [Fact]
        public void OfficialToStringTest()
        {
            var officDoc = new Official("Official memo π12", "Official memo", 451);
            var result = officDoc.ToString();
            Assert.Equal("Official memo π12; 451 Ã·; Official memo", result);
        }

        [Fact]
        public void ProtocolToStringTest()
        {
            var protDoc = new Protocol("Protocol π22122", "Protocol", 366);
            var result = protDoc.ToString();
            Assert.Equal("Protocol π22122; 366 Ã·; Protocol", result);
        }

        [Fact]
        public void AnalyticalToStringTest()
        {
            var anDoc = new Analytical("Special conclusion", "—onclusion", 215);
            var result = anDoc.ToString();
            Assert.Equal("Special conclusion; 215 Ã·; —onclusion", result);
        }
    }
}