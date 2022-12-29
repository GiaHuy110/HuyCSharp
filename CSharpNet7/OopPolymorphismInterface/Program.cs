using OopPolymorphismInterface;

SomeFile some = new();
some.ReadFile();
some.WriteTextFile();
some.WriteBinaryFile();

((IBinaryFile)some).ShowInfo();
(some as IBinaryFile).ShowInfo();
//=========================
ManyFile many = new();
many.WriteBinaryFile();
(many as IBinaryFile).ReadFile();
(many as IBinaryFile).ShowInfo();

IBinaryFile bf = new SomeFile();
bf.ShowInfo();
bf.ReadFile();
bf.WriteBinaryFile();

bf = new SomeFile();
bf.ShowInfo();
bf.ReadFile();
bf.WriteBinaryFile();