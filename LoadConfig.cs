using CHITest.Classes;
using CHITest.Numbers;
using Ninject.Modules;

namespace CHITest;

public class LoadConfig : NinjectModule
{
    public override void Load()
    {
        Bind1_9();
        Bind10_19();
        Bind20_90();
        Bind100_900();
        BindIterations();
    }

    private void Bind1_9()
    {
        Bind<CaseType>().To<Num1>().Named("1");
        Bind<CaseType>().To<Num2>().Named("2");
        Bind<CaseType>().To<Num3>().Named("3");
        Bind<CaseType>().To<Num4>().Named("4");
        Bind<CaseType>().To<Num5_79>().Named("5").WithConstructorArgument("root", "пят");
        Bind<CaseType>().To<Num5_79>().Named("6").WithConstructorArgument("root", "шест");
        Bind<CaseType>().To<Num5_79>().Named("7").WithConstructorArgument("root", "сем");
        Bind<CaseType>().To<Num8>().Named("8").WithConstructorArgument("root", "восьм");
        Bind<CaseType>().To<Num5_79>().Named("9").WithConstructorArgument("root", "девят");
    }

    private void Bind20_90()
    {
        Bind<CaseType>().To<Num5_79>().Named("20").WithConstructorArgument("root", "двадцат");
        Bind<CaseType>().To<Num5_79>().Named("30").WithConstructorArgument("root", "тридцат");
        Bind<CaseType>().To<Num40_7090>().Named("40").WithConstructorArgument("root", "сорок");
        Bind<CaseType>().To<Num50_70>().Named("50").WithConstructorArgument("root", "пят");
        Bind<CaseType>().To<Num50_70>().Named("60").WithConstructorArgument("root", "шест");
        Bind<CaseType>().To<Num50_70>().Named("70").WithConstructorArgument("root", "сем");
        Bind<CaseType>().To<Num80>().Named("80").WithConstructorArgument("root", "восьм");
        Bind<CaseType>().To<Num40_7090>().Named("90").WithConstructorArgument("root", "девяност");
    }

    private void Bind10_19()
    {
        Bind<CaseType>().To<Num5_79>().Named("10").WithConstructorArgument("root", "десят");
        Bind<CaseType>().To<Num5_79>().Named("11").WithConstructorArgument("root", "одиннадцат");
        Bind<CaseType>().To<Num5_79>().Named("12").WithConstructorArgument("root", "двенадцат");
        Bind<CaseType>().To<Num5_79>().Named("13").WithConstructorArgument("root", "тринадцат");
        Bind<CaseType>().To<Num5_79>().Named("14").WithConstructorArgument("root", "четырнадцат");
        Bind<CaseType>().To<Num5_79>().Named("15").WithConstructorArgument("root", "пятнадцат");
        Bind<CaseType>().To<Num5_79>().Named("16").WithConstructorArgument("root", "шестнадцат");
        Bind<CaseType>().To<Num5_79>().Named("17").WithConstructorArgument("root", "семнадцат");
        Bind<CaseType>().To<Num5_79>().Named("18").WithConstructorArgument("root", "восемнадцат");
        Bind<CaseType>().To<Num5_79>().Named("19").WithConstructorArgument("root", "девятнадцат");
    }

    private void Bind100_900()
    {
        Bind<CaseType>().To<Num100>().Named("100").WithConstructorArgument("root", "ст");
        Bind<CaseType>().To<Num200>().Named("200");
        Bind<CaseType>().To<Num300>().Named("300");
        Bind<CaseType>().To<Num400>().Named("400");
        Bind<CaseType>().To<Num500_700900>().Named("500").WithConstructorArgument("root", "пят");
        Bind<CaseType>().To<Num500_700900>().Named("600").WithConstructorArgument("root", "шест");
        Bind<CaseType>().To<Num500_700900>().Named("700").WithConstructorArgument("root", "сем");
        Bind<CaseType>().To<Num800>().Named("800").WithConstructorArgument("root", "восьм");
        Bind<CaseType>().To<Num500_700900>().Named("900").WithConstructorArgument("root", "девят");
    }

    private void BindIterations()
    {
        Bind<GenderType>().To<Num1000>().Named("1000").WithConstructorArgument("gender", "Ж");
        Bind<GenderType>().To<Num1000000>().Named("1000000").WithConstructorArgument("gender", "М");
        Bind<GenderType>().To<Num1000000000>().Named("1000000000").WithConstructorArgument("gender", "М");
    }
}