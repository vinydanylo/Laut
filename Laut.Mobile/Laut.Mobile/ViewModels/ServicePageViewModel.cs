using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Laut.Mobile.ViewModels
{
	public class ServicePageViewModel : BindableBase
	{
        private ObservableCollection<Service> _services;
        public ObservableCollection<Service> Services
        {
            get { return _services; }
            set { SetProperty(ref _services, value); }
        }
        public ServicePageViewModel()
        {
            Services = new ObservableCollection<Service>();

            Services.Add(new Service
            {
                Name = "Sintonia e Avalização de malhas de controle insdustriais",
                Description = "Temos uma ferramenta para o monitoramento, avaliação e sintonia de malhas de controle de processos industriais, que permite a avaliação do desempenho de malhas de controle através de índices de desempenho previamente definidos e, em caso de necessidade, a realização de forma automática da sintonia das malhas. O uso dessa ferramenta implica em benefícios econômicos ao processo decorrente de menor desgaste dos atuadores e de uma maior estabilidade das variáveis do processo."
            });
            Services.Add(new Service
            {
                Name = "Programação de sistemas supervisionados",
                Description = "Desenvolvemos telas de sistemas supervisórios, incluindo o planejamento do sistema, a elaboração das telas e subtelas de supervisão e a comunicação com CLPs de diversos fabricantes."
            });
            Services.Add(new Service
            {
                Name = "Programação de controladores lógicos programáveis",
                Description = "Elaboramos programas de automação para CLPs em diversas linguagens, incluindo Ladder, Grafcet e Blocos de Função e para equipamentos de diversos fabricantes."
            });
            Services.Add(new Service
            {
                Name = "Treinamento em controle de processos industriais",
                Description = "Realizamos treinamento em controle de processos industriais, usando plantas didáticas industriais disponíveis no laboratório. Esse treinamento permite a apresentação e demonstração de conceitos básicos de ações de controle, sintonia de malhas de controle, controle em cascata, entre outros, usando plantas equipadas com instrumentação industrial."
            });
            Services.Add(new Service
            {
                Name = "Projeto de sistemas de automação predial e residencial",
                Description = "Elaboramos projetos de automação predial, incluindo segurança eletrônica, reuso de água cinza, controle de temperatura e micro geração de energia elétrica usando painéis fotovoltaicos. Um projeto dessa natureza possibilita o uso racional da água e energia elétrica em uma edificação, resultado em economia e um retorno do investimento em curto prazo."
            });
            Services.Add(new Service
            {
                Name = "Manutenção em equipamentos eletrônicoos voltados para a automação insdustrial e predial",
                Description = "Realizamos manutenção em Controladores Lógicos Programáveis (CLPs), computadores e outros equipamentos eletrônicos utilizados em automação, com diagnóstico dos defeitos e a troca de componentes, em caso de necessidade."
            });
            Services.Add(new Service
            {
                Name = "Treinamento em sotfwares voltados à elevação artificial de petróleo",
                Description = "Realizamos treinamentos em softwares voltados à automação de poços de petróleo, incluindo os métodos de elevação artificial por Bombeio Mecânico, Gás Lift, Bombeio Centrífugo Submerso (BCS) e Bombeio por Cavidades Progressivas (BCP)."
            });
        }
	}

    public class Service
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}
