using OopPolymorphismOverriding;

Parent pa = new();
pa.Show();
pa.Display();

ChildOne Chil = new();
Chil.Show();
Chil.Display();

Parent p = new ChildOne();
p.Display();
p.Show(); // show của cha, chứ ko phải của con. 