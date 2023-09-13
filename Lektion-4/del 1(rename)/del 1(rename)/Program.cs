using del_1_rename_.Services;



/*
    Access Modifiers
    ------------------------------------------------------
    private         acessbar bara inom scopet (dvs { }) som variabeln inom.
    public          acessbar överallt i hela solutionen, dvs även mellan olika projekt.
    internal        accessbar överallt i hela projektet, men inte mellan olika projekt.
    


*/

//Vi gör en instans av en customerService så vi kan använda den. 
var customerService = new CustomerService();

customerService.GetCustomers();
