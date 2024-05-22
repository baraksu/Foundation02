using Bagrut2019Q01;

namespace Bagrut2019Q01Tests
{
    public class Q01Extract
    {
        [Fact]
        public void Extract_NoString_Return0()
        {
            string[] arr = { "ab,de" };
            int count = Bagrut2019Q01Program.Exact(arr, 3);
            Assert.Equal(0, count);
        }
        [Fact]
        public void Extract_2String_Return2()
        {
            string[] arr = { "ab","de" };
            int count = Bagrut2019Q01Program.Exact(arr, 2);
            Assert.Equal(2, count);
        }
    }
}