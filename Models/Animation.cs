namespace projetoHope.Models
{
    public class Animation
    {
        //Animation tremer para coponentes visuais, ou seja, botões, label, entry, imagens, etc ...
        static public async void Tremer(VisualElement elemento)
        {
            //Primeiro preciso validar se o elemento não está nulo, ou seja, se ja foi criado
            //Se não existir abortamos a execução.
            if (elemento == null)
                return; //abortar

            //Definimops o tempo
            uint tempo = 50;

            //Lista de deslocamento para a animação
            var listaDeslocamentos = new[] { -15, 15, -10, 10, -5, 5 };

            //Loop para aplicar o deslocamento
            foreach (var deslocamento in listaDeslocamentos)
                await elemento.TranslateTo(deslocamento, 0, tempo);
            elemento.TranslationX = 0;
        }
    }
}
