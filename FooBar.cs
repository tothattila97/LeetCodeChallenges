using System.Threading;

public class FooBar {
    private int n;
    private AutoResetEvent resetevent1 = new AutoResetEvent(true);
    private AutoResetEvent resetevent2 = new AutoResetEvent(false);
    
    // In case of ManualResetEvent class the call of Reset() method is necessary.
    //private ManualResetEvent resetevent1 = new ManualResetEvent(true);
    //private ManualResetEvent resetevent2 = new ManualResetEvent(false);

    public FooBar(int n) {
        this.n = n;
    }

    public void Foo(Action printFoo) {
        
        for (int i = 0; i < n; i++) {
            resetevent1.WaitOne();        	
        	printFoo();
            //resetevent1.Reset();
            resetevent2.Set();            
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
            resetevent2.WaitOne();        
        	printBar();
            //resetevent2.Reset();
            resetevent1.Set();            
        }
    }
}
