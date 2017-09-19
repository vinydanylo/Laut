using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Laut.Mobile.ViewModels
{
	public class ProjectPageViewModel : BindableBase
	{
        private ObservableCollection<Project> _projects;
        public ObservableCollection<Project> Projects
        {
            get { return _projects; }
            set { SetProperty(ref _projects, value); }
        }
        public ProjectPageViewModel()
        {
            Projects = new ObservableCollection<Project>();

            Projects.Add(new Project
            {
                Name = "AUTOPOC",
                Description = "Projeto relacionado à automação da elevação artificial, executado desde 2001 e que trata da pesquisa e do desenvolvimento de equipamentos e sistemas computacionais para supervisão, simulação, otimização e controle dos métodos de elevação artificial de petróleo. Já foram desenvolvidos vários produtos no âmbito deste projeto, sendo o sistema supervisório SISAL o de maior aplicação."
            });
            Projects.Add(new Project
            {
                Name = "DTVZ/SONIC",
                Description = "Este projeto está sendo desenvolvido pela mesma equipe desde fevereiro de 2003. Em uma primeira fase foram instalados no duto entre ETB e Upanema, da UN-RNCE da Petrobras, três pontos de coleta de dados de pressão. Cada ponto é constituído basicamente de um transmissor de pressão, um PLC e um rádio modem, instalados em painéis apropriados. Os pontos de coleta transmitem os seus dados, via rádio, para as estações mais próximas, nas quais os softwares de processamento de sinais e de supervisão estão rodando e sinalizarão os possíveis vazamentos no duto em questão. Neste primeiro projeto, os métodos implementados são baseados no ruído de pressão e no uso de redes neurais e Wavelets. Atualmente, estamos estudando e implementando métodos de detecção de vazamentos baseados em dispositivos acústicos em um outro duto da Petrobras. O sistema tem pontos de coleta de dados de pressão nas duas extremidades do duto e um sistema de processamento de sinais, com o uso de DSPs e sistemas supervisórios."
            });
            Projects.Add(new Project
            {
                Name = "CONPETRO",
                Description = "O objetivo do projeto foi desenvolver e aplicar técnicas de controle avançado, em particular Controle Preditivo, na Torre Desbutanizadora da UPGN-II do Pólo de Guamaré para otimizar a produção de GLP. Quatro principais atividades foram desenvolvidas em paralelo para obterem-se os seguintes produtos: Programa de controle avançado em linguagem C++; Simulação das Torres; Preditor Neural e Proposta de uma Nova Malha de Controle."
            });
            Projects.Add(new Project
            {
                Name = "REDICONT",
                Description = "Objetiva a aplicação de técnicas de controle ditas não convencionais, como as preditivas (incluindo o PID preditivo), adaptativas (incluindo o PID adaptativo) e inteligentes, que são reconhecidamente eficientes no controle de plantas não-lineares. Porém, apesar deste fato, a implementação das mesmas em processos reais ainda é bastante restrita, principalmente devido à dificuldades de programação destas técnicas na instrumentação industrial atual (controladores multi e single-loop e CLPs). A idéia deste projeto é estudar e implementar estas técnicas em processos utilizados na indústria do petróleo. As técnicas de controle serão implementadas em software comunicando-se com CLPs."
            });
            Projects.Add(new Project
            {
                Name = "REDIC-ADAP",
                Description = "A Rede Cooperativa de Pesquisa em Instrumentação e Controle (REDIC), aprovada pela FINEP em 2001, é formada por 12 instituições das regiões Norte-Nordeste, incluindo universidades, centros federais de educação tecnológica e institutos de pesquisa. São elas: UFPA, UFRN, UFBA, UFPE, UFCG, UFC, CEFET-RN, CEFET-SE, CEFET-BA, CEPED-BA, UNIFOR e ITEP-PE. A REDIC atualmente desenvolve pesquisas para o setor de petróleo e gás em 9 projetos, ligados aos temas medição de petróleo, controle de processos e automação da elevação artificial de petróleo. Os projetos desenvolvidos compartilham interesses mútuos, com auxílio recíproco, e visam atender as necessidades das indústrias. O trabalho em rede pretende somar esforços, agregando competências de várias instituições das regiões norte-nordeste, de modo a atender às necessidades do setor de petróleo e gás e de outros setores. Dentre estas competências podemos destacar: redes industriais, metrologia aplicada, controle avançado, inteligência artificial, microeletrônica/nanoeletrônica e instrumentação industrial."
            });
            Projects.Add(new Project
            {
                Name = "AIPETRO",
                Description = "Neste projeto são desenvolvidos sistemas computacionais para o suporte à operação do processo, para o diagnóstico de falhas e para o controle avançado, os quais serão integrados à rede Petrobras e comunicar-se-ão com sistemas de automação e controle já utilizados pela Petrobras/CENPES, tais como BR-PerfeX, BR-Tuning e BR-AlarmExpert. Os sistemas serão implantados na Planta de Processamento Primário de Petróleo (5P) que está sendo construída no Núcleo Experimental Engenheiro Baruzzi (NuEx), localizado junto à Estação de Processamento de Atalaia, em Aracaju-SE, visando uma simulação prática, mas serão elaborados com o foco na aplicação à plataformas do Pré-Sal, permitindo a operação remota destas plataformas com inteligência e confiabilidade."
            });
            Projects.Add(new Project
            {
                Name = "AVANSAL",
                Description = "O objetivo principal deste projeto é a produção de um software para aplicação de controle avançado, implementando técnicas de controle preditivo multivariável, identificação/re-identificação de modelos e avaliação do desempenho de malhas de controle. Outro objetivo a ser atingido é a capacitação de uma equipe para dar suporte e manutenção ao sistema desenvolvido, visando a sua aplicação prática."
            });
            Projects.Add(new Project
            {
                Name = "AUTODOC",
                Description = "O projeto tem como objetivo o desenvolvimento de um software que gere um documento de Projeto de Engenharia a partir de uma interface de entrada. A interface proposta é uma planilha eletrônica padrão para a entrada de dados. Este projeto será desenvolvido em parceria com a empresa Altus, sediada em São Leopoldo-RS e que desenvolve, fabrica e fornece equipamentos de automação industrial e serviços associados. Como se trata de um software de complexidade média pretende-se empregar uma metodologia ágil em seu desenvolvimento. Este tipo de metodologia baseia o foco do desenvolvimento nos requisitos levantados pelo cliente através da descrição de cenários. O cronograma de desenvolvimento irá prever a entrega de versões de teste ao cliente e, ao final, uma versão validada e testada."
            });
            Projects.Add(new Project
            {
                Name = "GERINE",
                Description = "Neste projeto pretende-se desenvolver metodologias e processos que permitam as seguintes funcionalidades no nível gerencial da automação industrial: Definição de dados relevantes para gerência de informação; Tratamento de dados em tempo real, com propriedades de compressão, bufferização e filtragem; Integração do sistema desenvolvido com o atual sistema de informações da produção da Petrobras (SIP); Geração de relatórios para análise gerencial estratégica, incluindo gráficos e informações sintetizadas."
            });
        }
	}

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
