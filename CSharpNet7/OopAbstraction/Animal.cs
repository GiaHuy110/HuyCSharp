namespace OopAbstraction;
internal abstract class Animal
{
    // các field
    private string fullname;
    private int age;

    // 1 phương thức mà không có body {}
    // => nó là abstract
    // 1 pt là abstract => class phải là abstract
    public void ShowInfor();
}
