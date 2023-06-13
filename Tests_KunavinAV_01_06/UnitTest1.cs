using KunavinAV_01_06;

namespace Tests_KunavinAV_01_06
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
        }

        //���� ��� ������ ������� (������)
        [Test]
        public void Test1 ()
        {
            string name = "����";
            decimal price = 49m;
            int count = 120;
            var product = new Product(name, price, count);

            var actual = product.Quality();
            var expected = 0.4084;
            Assert.That(expected, Is.EqualTo((double) actual).Within(0.0001));
        }

        //���� ��� ������ ������� (�� ������)
        [Test]
        public void Test2 ()
        {
            string name = "����";
            decimal price = 49m;
            int count = 120;
            var product = new Product(name, price, count);

            var actual = product.Quality();
            var expected = 0.4342;
            Assert.That(actual, Is.Not.EqualTo(expected).Within(0.0001));
        }

        //���� ��� ������ ������� ��������� (������)
        [Test]
        public void Test3 ()
        {
            string name = "����, �� ����� ������";
            decimal price = 69m;
            int count = 219;
            int year = 2021;
            var productChild = new ProductChild(name, price, count, year);

            var actual = productChild.Quality();
            var expected = 1.315068;
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }

        //���� ��� ������ ������� ��������� (�� ������)
        [Test]
        public void Test4 ()
        {
            string name = "����, �� ����� ������";
            decimal price = 69m;
            int count = 219;
            int year = 2021;
            var productChild = new ProductChild(name, price, count, year);

            var actual = productChild.Quality();
            var expected = 0.543677;
            Assert.That(actual, Is.Not.EqualTo(expected).Within(0.0001));
        }
    }
}