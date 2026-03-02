List<string> Lista = new List<string> { "rato", "cachorro", "camelo", "gato", "cachorro" };
Lista.RemoveAll(S => S.StartsWith("c"));

Console.WriteLine(string.Join(", ", Lista));