using System.Text;

namespace mis_clases

{
    public class Computadora
    {
        int capacidadDisco;
        int memoriaRam;
        string procesador;
        string sistemaOperativo;
        List<string> programas;
        string concatenado = "";

        private Computadora()
        {
            this.programas = new List<string>();
        }

        public Computadora(int capacidadDisco, int memoriaRam, string procesador, string sistemaOperativo)
            :this ()
        {
            this.capacidadDisco = capacidadDisco;
            this.memoriaRam = memoriaRam;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
        }

        public int CapacidadDisco { get => capacidadDisco; }
        public int MemoriaRam { get => memoriaRam; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }
        public string Programas
        {                     
            get
            {
                foreach (string programa in this.programas)
                {
                    this.concatenado+=$"{programa}, ";
                }

                return this.concatenado;
            }
        }


        public List<string> GetProgramas()
        {
            return programas;
        }

        public void SetPrograma(string programa)
        {
            programas.Add(programa);
        }

        public static List<string> ListadoDeProcesadores()
        {
            return new List<string> { "i5 12756", "ryzen 7 2563", "i7 8457", "ryzen 5 4567", "i9 8234" };

        }

        public static List<Computadora> listadoDeComputadoras()
        {
            return new List<Computadora> {
                new Computadora(500,16,"i5","Windows"),
                new Computadora(1,32,"ryzen 7","Windows"),
                new Computadora(2,32,"i7","Linux"),
                new Computadora(250,32,"ryzen 5","MacOS")


            };
        }

    }
}
