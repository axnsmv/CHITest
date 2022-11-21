using CHITest.Classes;
using Ninject;
using Ninject.Modules;

namespace CHITest;

public class Parser : IDisposable
{
    private readonly IKernel kernel;

    public Parser(params INinjectModule[] modules)
    {
        kernel = new StandardKernel(modules);
    }

    public void Dispose()
    {
        kernel.Dispose();
    }

    public string SumProp(long nSum, string sGender, string sCase)
    {
        var numberParts = PrepareNumber(nSum);
        var iterations = numberParts.Length - 1;

        for (var part = iterations; part >= 0; part--) DoIteration(numberParts[part], part, sGender, sCase);

        return StorageList.Build();
    }

    private int[] PrepareNumber(long number)
    {
        var list = new List<int>();
        while (number != 0)
        {
            var part = number % 1000;
            number = number / 1000;
            list.Add((int)part);
        }

        return list.ToArray();
    }

    private void DoIteration(int number, int part, string sGender, string sCase)
    {
        if (number == 0) return;
        var iterationRule = GetIteration((long)Math.Pow(1000, part));
        if (part > 0)
        {
            if (iterationRule != null)
            {
                iterationRule.Multiple = number > 1;
                sGender = iterationRule.Gender;
            }
        }

        var power = 0;
        while (number != 0)
        {
            var rule = GetRule(number);
            if (rule == null)
            {
                var iteration = (int)Math.Pow(10, 2 - power);
                var currentNumber = number / iteration * iteration;
                if (currentNumber != 0) rule = GetRule(currentNumber);
                power++;
                number %= iteration;
            }
            else
            {
                number = 0;
            }

            rule?.BuildString(sGender, sCase);
        }

        iterationRule?.BuildString(sGender, sCase);
    }

    private CaseType? GetRule(int item)
    {
        return kernel.TryGet<CaseType>(item.ToString());
    }

    private GenderType? GetIteration(long item)
    {
        return kernel.TryGet<GenderType>(item.ToString());
    }
}