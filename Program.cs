 internal class Program
    {
         struct tLibro{
                public string titulo;
                public string autor;
                public string editorial;
              
            };
            tLibro[] biblioteca;
            void cargarLibros(){
                for(int i = 0; i < biblioteca.Length; i++){
                    Console.Write("Ingresa el nombre del libro:");
                    biblioteca[i].titulo = Console.ReadLine();
                    Console.Write("Ingresa el autor del libro:");
                    biblioteca[i].autor = Console.ReadLine();
                    Console.Write("Ingresa la editorial del libro:");
                    biblioteca[i].editorial = Console.ReadLine();
                }
            }

            void mostrarlibros(){
                foreach (tLibro libro in biblioteca)
                {
                    Console.WriteLine($"Titulo del libro: {libro.titulo}");
                    Console.WriteLine($"Autor del libro: {libro.autor}");
                    Console.WriteLine($"Editorial del libro: {libro.editorial}");
                }
                Console.WriteLine();

                for(int i=0; i<biblioteca.Length;i++){
                    Console.WriteLine($"Titulo del libro: {biblioteca[i].titulo}");
                    Console.WriteLine($"Autor del libro: {biblioteca[i].autor}");
                    Console.WriteLine($"Editorial del libro: {biblioteca[i].editorial}");
                }
            }
        static void Main(string[] args)
        {
           const int maxcantidadLibros = 2;
           var prog = new Program();
           prog.biblioteca = new tLibro[maxcantidadLibros];

           prog.cargarLibros();
           prog.mostrarlibros();
        }
    }
