namespace Delegatewithlamba;


// public static void Myconfigurationmethod(MyServiceOptions myService)
// {
//     options.Url = "https://api.myprodservice.com";
//     options.TimeoutSeconds = 60;
//     options.EnableCaching = true;
// }
public class ServiceBuilder
{
    public void AddService(Action<MyServiceOptions> dummyref)
    {
        MyServiceOptions optionsinstance = new MyServiceOptions();
        dummyref(optionsinstance); //This is calling lamba dummref dummyref = optionsinstance => { optionsinstance.Name = "X"; };
    }
    
}

public class Program
{
    public static void Main(string[] args)
    {
        ServiceBuilder builder = new ServiceBuilder();
        builder.AddService(h =>
        {
            h.Url = "https://api.myprodservice.com";
            h.TimeoutSeconds = 60;
            h.EnableCaching = true;
        });
    }
}
//Dummref is varaible point to laambda 
Mental Notes 
1.When amethod which expects delagte is created , we need to prepare insatnce and pass instance to lambada pinter 
2.whwover calls this method can directly pass same isnatnce created inside above method with different variable and udpate assigned menst 