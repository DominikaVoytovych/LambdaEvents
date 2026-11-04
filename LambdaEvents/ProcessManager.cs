using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaEvents;

public class ProcessManager
{
    public event Action<int> OnProgressChanged; //оголошення події про прогрес
    public event Action OnCompleted; //оголошення події про завершення

    public void StartProcess()
    {
        for (int i = 1; i <= 3; i++)
        {
            //System.Threading.Thread.Sleep(500) - затримка виконання потоку на 500 мілісекунд
            System.Threading.Thread.Sleep(500); //імінтація роботи, показуємо прогрес
            //сповіщення про прогрес з використанням делегата Action<int>
            OnProgressChanged?.Invoke(i * 33);
        }

        OnCompleted?.Invoke(); //завершення погресу
    }
}
