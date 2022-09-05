using CalcProject.App;

namespace TestProject
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void TestCalc()
        {
            CalcProject.App.Calc calc = new();
            // ���� � ����������� �������� - ��'��� ���� ��������
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void RomanNumberParse()
        {
            Assert.AreEqual(2   , RomanNumber.Parse("II"));
            Assert.AreEqual(4   , RomanNumber.Parse("IV"));
            Assert.AreEqual(9   , RomanNumber.Parse("IX"));
            Assert.AreEqual(15  , RomanNumber.Parse("XV"));
            Assert.AreEqual(20  , RomanNumber.Parse("XX"));
            Assert.AreEqual(40  , RomanNumber.Parse("XL"));
            Assert.AreEqual(90  , RomanNumber.Parse("XC"));
            Assert.AreEqual(110 , RomanNumber.Parse("CX"));
            Assert.AreEqual(400 , RomanNumber.Parse("CD"));
            Assert.AreEqual(900 , RomanNumber.Parse("CM"));
            Assert.AreEqual(2000, RomanNumber.Parse("MM"));
            // Assert.AreEqual(RomanNumber.Parse("MCM"), 1900);
        }
    }
}
/*
 TDD - Test Driven Development - ����������� �������� �������
ϳ���� �� ������������� (����������� ��) ����� � ����
 ����� ��� ��'���� �'��������� �����, �� �� ���������.
 �� ����� ������� �� ����������� ������� ��������, ��������
 �� �����, �� ����� ������ ��'����.
������� �� �� - ��������� �� ���� ������������ �������,
 ������ ������� - ����������� �����
 */