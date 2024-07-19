<table>
<tr>
<Table>
  <tr>
    <td><a href= "https://www.fdc.org.br/"><img src="/imagens/logoFDC.png" alt="Fundação Dom Cabral" border="0"></td>
    <td>
      <a href= "https://www.inteli.edu.br/"><img src="/imagens/inteli-logo.png" alt="Inteli - Instituto de Tecnologia e Liderança" border="0"></a>
    </td>
  </tr>
</table>

# Legacy Lab

## Desenvolvido por Legacy Lab

## :student: Integrantes:

- <a href="https://www.linkedin.com/in/claramohammad/">Clara Mohammad</a>
- <a href="https://www.linkedin.com/in/kaiane-souza/">Kaiane Souza</a>
- <a href="https://www.linkedin.com/in/raissa-vieira-de-melo/">Raissa Vieira de Melo</a>
- <a href="https://www.linkedin.com/in/renanfeit/">Renan Feitosa</a>
- <a href="https://www.linkedin.com/in/théo-tosto-7a0a9922b/">Théo Tosto</a>

## Sumário

- [1. Termos e Abreviações](#1-termos-e-abreviações)

- [2. Visão Geral do Projeto](#2-visão-geral-do-projeto)
  - [2.1 Entendimento do Parceiro](#21-entendimento-do-parceiro)
    - [2.1.1 Partes Interessadas](#211-partes-interessadas)
    - [2.1.2 Análise da Indústria](#212-análise-da-indústria)
    - [2.1.3 Modelo de Negócio](#213-modelo-de-negócio)
    - [2.1.4 Tendências](#214-tendências)
    - [2.1.5 Players de Mercado](#215-players-de-mercado)
  - [2.2 Problema](#22-problema)

- [3. Proposta da Solução](#3-proposta-da-solução)
  - [3.1 Descritivo Geral da Solução](#31-descritivo-geral-da-solução)
  - [3.2 Partes Interessadas](#32-partes-interessadas)
  - [3.3 Proposta Tecnológica e Benefícios](#33-proposta-tecnológica-e-benefícios)
  - [3.4 Proposta de Valor (Value Proposition Canvas)](#34-proposta-de-valor-value-proposition-canvas)
  - [3.5 Matriz de Risco](#35-matriz-de-risco)
  - [3.6 Estimativa de Investimento](#36-estimativa-de-investimento)

- [4. Análise dos Processos](#4-análise-dos-processos)
  - [4.1 Cadeia de Valor](#41-cadeia-de-valor)
  - [4.2 Modelagem de Processos](#42-modelagem-de-processos)

- [5. Requisitos](#5-requisitos)
  - [5.1 Requisitos Funcionais](#51-requisitos-funcionais)
  - [5.2 Requisitos não Funcionais](#52-requisitos-não-funcionais)
  - [5.3 Casos de Uso](#53-casos-de-uso)
    - [5.3.1 User Stories](#531-user-stories)
    - [5.3.2 Diagrama de Casos de Uso](#532-diagrama-de-casos-de-uso)
  - [5.4 Casos de Uso x Requisitos Funcionais](#54-casos-de-uso-x-requisitos-funcionais)

- [6. Projeto de Solução](#6-projeto-de-solução)
  - [6.1 Diagrama de Classes](#61-diagrama-de-classes)
  - [6.2 Arquitetura da Solução](#62-arquitetura-da-solução)
  - [6.3 Diagrama de Implantação](#63-diagrama-de-implantação)
  - [6.4 Tecnologias e Ferramentas](#64-tecnologias-e-ferramentas)
  - [6.5 Padrões de Trabalho](#65-padrões-de-trabalho)

- [7. Interface](#7-interface)
  - [7.1 Projeto de Interface (Wireframes)](#71-projeto-de-interface-wireframes)
  - [7.2 Mockup](#72-mockup)
  - [7.3 Frontend](#73-frontend)
    - [7.3.1 Análise de Usabilidade e Implantação do Frontend](#731-análise-de-usabilidade-e-implantação-do-frontend)
    - [7.3.2 Utilização do Design System](#732-utilização-do-design-system)
    - [7.3.3 Análise de Heurísticas de Nielsen](#733-análise-de-heurísticas-de-nielsen)
    - [7.3.4 Zona do Polegar](#734-zona-do-polegar)
    - [7.3.5 Acessibilidade](#735-acessibilidade)

- [8. Projeto de Banco de Dados](#8-projeto-de-banco-de-dados)
  - [8.1 Especificação da Base de Dados para Modelo de Recomendação](#81-especificação-da-base-de-dados-para-modelo-de-recomendação)
  - [8.2 Modelo Conceitual](#82-modelo-conceitual)
  - [8.3 Modelo Lógico](#83-modelo-lógico)
    - [8.3.1 Etapas de Mapeamento](#831-etapas-de-mapeamento)
    - [8.3.2 Tabelas Finais](#832-tabelas-finais)

- [9. Construção da Solução](#9-construção-da-solução)
  - [9.1 Modelo de Recomendação](#91-modelo-de-recomendação)
  - [9.2 Estrutura da Solução](#92-estrutura-da-solução)
    - [9.2.1 Estrutura de Serviço do Backend](#921-estrutura-de-serviço-do-backend)
    - [9.2.2 Arquitetura MVC](#922-arquitetura-mvc)
    - [9.2.3 API externa](#923-api-externa)

- [10. Testes de Software](#10-testes-de-software)
  - [10.1 Testes de Usabilidade para Mockup](#101-testes-de-usabilidade-para-mockup)
  - [10.2 Testes de Integração](#102-testes-de-integração)
  - [10.3 Testes dos Serviços](#103-testes-dos-serviços)
  - [10.4 Integração do Modelo de Recomendação](#104-integração-do-modelo-de-recomendação)
    - [10.4.1 Testes de Integração do Modelo de Recomendação](#1041-testes-de-integração-do-modelo-de-recomendação)
    - [10.4.2 Diagrama de Sequência UML](#1042-diagrama-de-sequência-uml)

- [11. Procedimento de Implantação da Solução](#11-procedimento-de-implantação-da-solução)
  - [11.1 Procedimento de Implantação do Sistema](#111-procedimento-de-implantação-do-sistema)
  - [11.2 Procedimento de Implantação do Banco de Dados](#112-procedimento-de-implantação-do-banco-de-dados)
  - [11.3 Documentação Automática do Backend](#113-documentação-automática-do-backend)
                                         
- [12. Aperfeiçoamentos Futuros](#12-aperfeiçoamentos-futuros)
                                         
- [Referências](#referências)
- [Apêndice](#apêndice)


# 1. Termos e Abreviações

&emsp;&emsp;Nesta seção, vamos apresentar uma lista de termos e abreviações utilizadas na documentação, fornecendo definições claras para cada uma delas. Este recurso é fundamental para garantir a compreensão de termos técnicos e específicos mencionados, o objetivo é facilitar a leitura e a compreensão do conteúdo, promovendo uma comunicação mais eficiente.

**Arquitetura SOA**: A Arquitetura Orientada a Serviços (SOA) é um estilo de arquitetura de software que permite a criação de aplicações modulares e flexíveis, através da definição de serviços independentes e reutilizáveis. Nesse modelo, os serviços são componentes de software que realizam tarefas específicas e podem ser acessados por outros sistemas através de uma interface bem definida. A arquitetura SOA permite a integração de sistemas heterogêneos, facilitando a comunicação entre diferentes aplicações e a reutilização de serviços em diferentes contextos.

**FDC (Fundação Dom Cabral)**: A Fundação Dom Cabral é uma escola de negócios reconhecida pelo Financial Times como uma das líderes mundiais no desenvolvimento de executivos. A FDC busca desenvolver executivos, gestores públicos, empreendedores e organizações através da educação.

**UML (*Unified Modeling Language*)**: É uma linguagem padrão para especificar, visualizar, construir e documentar os artefatos de sistemas de software. A UML proporciona uma maneira padronizada para visualizar o design de um sistema. É usada para criar modelos de sistemas complexos, que ajudam a entender, projetar e manter os sistemas.

# 2. Visão Geral do Projeto

&emsp;&emsp;O projeto "CEO's Legacy" da Fundação Dom Cabral (FDC) é uma iniciativa inovadora que reúne CEOs de diversas indústrias para discutir temas relevantes do mundo corporativo e da gestão. Organizado em macrotemas, como sustentabilidade, tecnologia e gestão de crises, o projeto se aprofunda em microtemas específicos onde os participantes podem identificar desafios comuns e colaborar em soluções. Por exemplo, dentro de um macrotema de tecnologia, um microtema pode ser a integração de inteligência artificial na otimização de processos logísticos.

&emsp;&emsp;Este formato permite que executivos com necessidades complementares se encontrem. Aqueles que enfrentam desafios específicos podem se beneficiar das experiências e soluções de outros líderes que já passaram por problemas similares ou que possuem as tecnologias ou estratégias necessárias. A abordagem do "CEO's Legacy" não apenas fomenta a inovação e a troca de conhecimentos, mas também fortalece a rede de colaboração entre líderes empresariais, promovendo um crescimento conjunto e sustentável dentro do ecossistema empresarial.

## 2.1 Entendimento do Parceiro

&emsp;&emsp;A Fundação Dom Cabral (FDC) é uma escola de negócios brasileira de renome internacional, fundada em 1976 por um grupo de professores da Universidade Federal de Minas Gerais. Localizada em Nova Lima, Minas Gerais, a FDC é reconhecida por sua excelência em programas de educação executiva, desenvolvimento de lideranças e consultoria para empresas e gestores. Frequentemente listada em rankings globais como uma das melhores escolas de negócios do mundo, a FDC se destaca pela adoção de uma metodologia prática e focada nas reais necessidades do mercado.

&emsp;&emsp;Além dos programas de MBA e educação executiva, a FDC estabelece parcerias estratégicas com escolas de negócios internacionais, ampliando sua influência e a capacidade de oferecer uma perspectiva global para seus alunos. Esta abordagem colaborativa é evidenciada também em iniciativas como o projeto "CEO Legacy", que reflete o compromisso da FDC com o desenvolvimento continuado de lideranças. O "CEO Legacy" permite que CEOs de diversas indústrias colaborem em desafios macroeconômicos e explorem soluções inovadoras juntos, fomentando um ambiente rico em troca de experiências e aprendizado colaborativo. Essa integração de líderes empresariais fortalece a rede de ex-alunos e parceiros da FDC, promovendo o crescimento sustentável e a inovação dentro do ecossistema empresarial global.

&emsp;&emsp;Neste contexto, o projeto "CEO Legacy" exemplifica o compromisso da FDC com a evolução contínua da educação executiva, facilitando a colaboração entre CEOs de diversas indústrias. Alinhado com essa visão, a FDC também apoiou o desenvolvimento do "LegacyLab", uma plataforma que aprimora a experiência do "CEO Legacy" ao permitir uma interação mais dinâmica e direta entre os líderes. Essa solução tecnológica reflete o espírito de inovação da FDC, facilitando a autonomia dos CEOs na gestão de seus projetos e na exploração de novas oportunidades de colaboração, promovendo assim uma rede de negócios mais conectada e responsiva às rápidas mudanças do mercado global.

### 2.1.1 Partes Interessadas

&emsp;&emsp;No projeto "CEO's Legacy" da Fundação Dom Cabral (FDC), as partes interessadas primárias incluem os CEOs participantes, empresas representadas por esses líderes, e os facilitadores e especialistas da FDC que coordenam e guiam as discussões e atividades. Os CEOs, que vêm de diversas indústrias, trazem para o projeto suas experiências únicas, desafios de gestão e expectativas de soluções inovadoras. Eles são tanto beneficiários quanto contribuintes, compartilhando conhecimentos e aprendendo uns com os outros em um ambiente colaborativo.

&emsp;&emsp;As empresas envolvidas no projeto se beneficiam diretamente ao terem seus líderes expostos a novas ideias e práticas de gestão que podem ser implementadas para melhorar a eficiência e a competitividade. Por outro lado, a FDC, como facilitadora, solidifica sua posição como líder em educação executiva, mantendo-se atualizada com as tendências do mercado e as necessidades dos líderes empresariais. Este projeto não só fortalece a rede de ex-alunos e parceiros da FDC, mas também promove um ecossistema de inovação e troca contínua de conhecimentos entre os altos executivos.
### 2.1.2 Análise da Indústria

&emsp;&emsp;A Fundação Dom Cabral (FDC) opera no setor de educação executiva e consultoria de gestão, uma indústria que desempenha um papel crucial no desenvolvimento de líderes empresariais e na implementação de estratégias corporativas eficazes. Este setor é altamente competitivo e globalizado, com participantes que vão desde instituições acadêmicas tradicionais até fornecedores de cursos online e consultorias especializadas.

#### Tendências da Indústria:

- **Digitalização:** A transformação digital acelerada por eventos como a pandemia da COVID-19 tem levado à adoção crescente de plataformas de aprendizado online e programas híbridos. Instituições como a FDC têm integrado tecnologias digitais para oferecer flexibilidade e acesso ampliado aos seus programas.

- **Personalização:** Há uma demanda crescente por programas personalizados que atendam às necessidades específicas das empresas e dos profissionais. A FDC se destaca por desenvolver soluções customizadas que são diretamente alinhadas com as estratégias e desafios organizacionais de seus clientes.

- **Internacionalização:** Com a globalização dos negócios, há uma necessidade cada vez maior de programas que ofereçam perspectivas internacionais e capacidade de atuar em mercados globais. Parcerias com instituições de renome mundial são essenciais para ampliar o alcance e enriquecer os currículos.

#### Análise Competitiva:

&emsp;&emsp;A FDC compete não apenas com outras escolas de negócios brasileiras, mas também com instituições internacionais renomadas. No entanto, sua forte reputação na América Latina e os laços estreitos com a indústria local proporcionam uma vantagem competitiva significativa. A escola é frequentemente comparada com outras grandes nomes como INSEAD, Harvard Business School e IE Business School em termos de qualidade e impacto.

**Desafios e Oportunidades:**

- **Desafios:** Manter a relevância em um mercado em rápida mudança e assegurar que os programas estejam alinhados com as últimas tendências empresariais e tecnológicas são desafios constantes.

- **Oportunidades:** Há uma oportunidade contínua de expandir a presença internacional e desenvolver programas que abordem questões emergentes como sustentabilidade, inovação tecnológica e mudanças geopolíticas.

&emsp;&emsp;Em suma, a FDC está bem posicionada na indústria de educação executiva e consultoria de gestão, beneficiando-se de sua capacidade de adaptar-se e responder às necessidades de um ambiente de negócios em constante evolução.

### 2.1.3 Modelo de Negócio

&emsp;&emsp;O modelo de negócio da Fundação Dom Cabral (FDC) é centrado na oferta de educação executiva e serviços de consultoria de alto nível para líderes e organizações. Este modelo permite à FDC atender às necessidades específicas de desenvolvimento profissional e estratégico de executivos e empresas em diversos setores. Aqui estão alguns elementos-chave desse modelo:

#### 1. Programas Customizados e Abertos

&emsp;&emsp;A FDC oferece uma gama diversificada de programas, incluindo cursos abertos a indivíduos e programas customizados desenvolvidos especificamente para atender às necessidades de empresas clientes. Os programas abertos permitem que profissionais de diferentes empresas e setores se desenvolvam em áreas chave da gestão empresarial, enquanto os programas customizados são projetados em colaboração com as empresas para abordar desafios específicos e alcançar objetivos estratégicos definidos.

#### 2. Parcerias e Colaborações Internacionais

&emsp;&emsp;Parte do modelo de negócios da FDC envolve parcerias com instituições de ensino e empresas internacionais. Essas parcerias permitem um intercâmbio rico de conhecimento e práticas de gestão, além de oferecer aos alunos da FDC uma perspectiva global. As colaborações também ampliam o alcance da FDC e fortalecem sua posição no mercado global de educação executiva.

#### 3. Consultoria e Pesquisa Aplicada

&emsp;&emsp;Além dos programas de educação, a FDC oferece serviços de consultoria que ajudam as organizações a implementar mudanças estratégicas, melhorar operações e inovar em seus processos e produtos. A consultoria é muitas vezes apoiada por pesquisa aplicada, que permite à FDC e seus clientes entenderem melhor as tendências do mercado e os desafios específicos do setor.

#### 4. Foco em Liderança e Desenvolvimento Sustentável

&emsp;&emsp;O modelo de negócios da FDC também se destaca pelo foco no desenvolvimento de líderes capazes de conduzir negócios de forma ética e sustentável. Isso reflete uma tendência global na educação executiva, onde a sustentabilidade e a responsabilidade corporativa são cada vez mais vistas como essenciais para o sucesso de longo prazo das empresas.

&emsp;&emsp;Este modelo de negócios não apenas garante que a FDC se mantenha relevante em um mercado competitivo, mas também contribui para o desenvolvimento de uma comunidade empresarial mais inovadora, responsável e adaptável.

### 2.1.4 Tendências

&emsp;&emsp;No setor de educação executiva, onde a Fundação Dom Cabral (FDC) é uma participante ativa, várias tendências estão moldando o futuro e influenciando o desenvolvimento de programas e serviços. Essas tendências refletem as mudanças no ambiente de negócios global, as demandas de novas habilidades e a crescente importância da tecnologia e da sustentabilidade. Aqui estão algumas tendências chave:

#### 1. Educação Digital e Tecnologia Emergente

&emsp;&emsp;A digitalização da educação é uma tendência dominante, acelerada pela pandemia de COVID-19. As escolas de negócios, incluindo a FDC, estão incorporando tecnologias emergentes como inteligência artificial, realidade virtual e plataformas de aprendizado online para oferecer experiências educativas mais flexíveis e acessíveis. Essas tecnologias permitem simulações realistas e personalizadas de cenários de negócios, além de facilitar o acesso a programas de qualidade para alunos globais.

#### 2. Personalização do Aprendizado

&emsp;&emsp;Existe uma demanda crescente por programas que possam ser personalizados para atender às necessidades específicas dos alunos e das organizações. A FDC atende a essa demanda através de programas customizados que são desenhados em colaboração com empresas para alinhar o conteúdo educacional com os objetivos estratégicos e desafios específicos das organizações. A personalização também se estende ao desenvolvimento de trilhas de aprendizado individuais para lideranças, focando em suas áreas de interesse e desenvolvimento de carreira.

#### 3. Foco em Soft Skills e Liderança Adaptativa

&emsp;&emsp;Além das habilidades técnicas, as soft skills como comunicação eficaz, pensamento crítico, e resiliência estão se tornando cada vez mais importantes. As escolas de negócios estão, portanto, integrando mais conteúdo focado no desenvolvimento de lideranças adaptativas e emocionalmente inteligentes, preparando-as para liderar em ambientes de negócios voláteis e incertos.

#### 4. Sustentabilidade e Responsabilidade Corporativa

&emsp;&emsp;À medida que a sustentabilidade se torna uma prioridade para consumidores e empresas, as escolas de negócios estão incorporando a educação para a sustentabilidade em seus currículos. A FDC, por exemplo, está aumentando o foco em ensinar como as práticas de negócios podem ser alinhadas com objetivos ambientais e sociais, preparando líderes para enfrentar desafios como a mudança climática e a desigualdade social.

#### 5. Expansão Internacional e Colaborações Globais

&emsp;&emsp;A globalização continua a ser uma força poderosa na educação executiva, com instituições como a FDC expandindo sua presença internacional através de parcerias e programas conjuntos com escolas de negócios ao redor do mundo. Isso enriquece a experiência educacional, oferece uma perspectiva mais ampla e prepara os alunos para liderar em uma economia global.

&emsp;&emsp;Essas tendências estão direcionando como as instituições de educação executiva como a FDC estão se adaptando e inovando para atender às necessidades dos líderes empresariais de hoje e do futuro.

### 2.1.5 Players de Mercado

&emsp;&emsp;No mercado de educação executiva, a Fundação Dom Cabral (FDC) está entre diversos players significativos tanto no âmbito nacional quanto internacional. Esse mercado inclui uma variedade de instituições que oferecem programas de liderança, gestão e desenvolvimento profissional. Abaixo estão alguns dos principais players do mercado:

#### 1. Escolas de Negócios Globais

- **Harvard Business School (EUA):** Uma das escolas de negócios mais prestigiadas mundialmente, conhecida por seus programas de MBA e educação executiva.
- **INSEAD (França/Singapura):** Com campus na Europa e na Ásia, é famosa por seus programas intensivos e foco global.
- **London Business School (Reino Unido):** Destaca-se em finanças e liderança internacional, atraindo estudantes de todo o mundo.

#### 2. Escolas de Negócios Brasileiras

- **Insper:** Conhecido por seus programas rigorosos e foco em inovação e empreendedorismo.
- **Escola de Administração de Empresas de São Paulo da Fundação Getulio Vargas (FGV EAESP):** Oferece uma gama ampla de programas de educação executiva e tem forte influência no cenário empresarial brasileiro.
- **IBMEC:** Oferece programas de pós-graduação e educação executiva com forte ênfase em negócios e economia.

&emsp;&emsp;Estes players representam a diversidade e a qualidade do mercado de educação executiva, cada um trazendo suas particularidades e focos estratégicos que os tornam referências em suas áreas de atuação.

## 2.2 Problema

&emsp;&emsp;O projeto "CEO's Legacy" da Fundação Dom Cabral enfrenta desafios significativos de escalabilidade e eficiência operacional. Atualmente, o processo manual em que CEOs precisam se comunicar diretamente uns com os outros para expressar interesse limita significativamente o número de interações e a rapidez com que estas podem ser realizadas. Além disso, a dependência dos CEOs na gestão da FDC para visualizar e selecionar projetos restringe a autonomia dos líderes em explorar iniciativas conforme seu interesse e necessidade. Isso sobrecarrega a equipe da FDC, que precisa manualmente facilitar conexões e gerenciar informações, tornando o processo menos ágil e mais susceptível a atrasos e erros. Tais limitações comprometem a capacidade do projeto de expandir seu alcance e de engajar efetivamente um número maior de líderes empresariais em uma variedade mais ampla de temas, o que é essencial para maximizar o potencial de inovação e colaboração dentro da rede.

# 3. Proposta da Solução

&emsp;&emsp;Nesta seção, vamos apresentar uma proposta de solução para o projeto em questão, explicando a necessidade de criar um aplicativo para dispositivos móveis que facilite a gestão das sinergias dos projetos de cada empresa associada ao CEOs' Legacy. O LegacyLab é uma ferramenta desenvolvida para resolver o problema de cadastro e gestão de projetos, fornecendo aos CEOs um meio eficiente de acompanhar e se engajar em projetos que possam gerar sinergias produtivas.

## 3.1 Descritivo Geral da Solução

&emsp;&emsp;O LegacyLab é um aplicativo inovador desenvolvido para enriquecer a comunidade do programa CEO’s Legacy, iniciativa da Fundação Dom Cabral. A solução visa facilitar a gestão autônoma e eficiente dos projetos pelos próprios CEOs, permitindo que registrem, atualizem e explorem projetos e todos seus detalhes de maneira intuitiva e interativa. O aplicativo não apenas simplifica a administração dos projetos, mas também permite que os CEOs avaliem seus interesses por projetos de outros, registrem sinergias e acompanhem as sinergias existentes, enriquecendo a gestão de suas conexões e colaborações.

&emsp;&emsp;Através de um sistema de recomendação, com base no perfil do usuário e seu histórico de avaliações, a solução sugere projetos que podem resultar em sinergias produtivas, aumentando as oportunidades de colaboração entre os CEOs e estimulando a inovação. Essencialmente, o LegacyLab amplifica as oportunidades de sinergia dentro da comunidade, permitindo aos usuários descobrir e engajar-se em colaborações valiosas que alavancam seus objetivos empresariais e impacto social.

&emsp;&emsp;Para a Fundação Dom Cabral, o LegacyLab representa uma ferramenta estratégica para fortalecer o vínculo entre os líderes empresariais e ampliar o alcance das iniciativas de desenvolvimento executivo. A solução não só promove uma maior integração e colaboração entre os membros da CEO’s Legacy mas também reflete e promove os valores centrais do programa: colaboração, crescimento e construção de legado. Além disso, o aplicativo proporciona à Fundação uma visão mais clara e quantificável do impacto e da eficácia de suas atividades, consolidando seu papel como um catalisador de liderança empresarial e transformação social.

## 3.2 Partes Interessadas

&emsp;&emsp;Partes interessadas são indivíduos ou grupos que têm interesse direto ou indireto no projeto e que podem ser afetados por suas atividades, resultados ou decisões. No contexto do desenvolvimento da aplicação móvel para networking entre CEOs, as partes interessadas incluem:

#### Fundação Dom Cabral (FDC):

&emsp;&emsp;A Fundação Dom Cabral, uma renomada escola de negócios no Brasil, tem com o LegacyLab uma oportunidade de inovação e avanço no seu projeto CEO’s Legacy.  Este interesse decorre da capacidade do projeto de potencializar o legado e a influência da FDC através da melhoria na gestão e interação entre líderes empresariais. O LegacyLab está alinhado com a missão da FDC de desenvolver líderes capazes de promover transformações sustentáveis e impactantes no ambiente empresarial.

#### Gestão do Programa CEO's Legacy:

&emsp;&emsp;O programa CEO’s Legacy, operado pela FDC, se beneficiará diretamente do LegacyLab por otimizar a gestão e a interação entre os CEOs. O LegacyLab, ao oferecer uma plataforma focada na coordenação e conexão dessas atividades, está diretamente alinhado com a missão do programa de aumentar a sinergia e potencializar as iniciativas de seus membros. A implementação do LegacyLab permite à equipe de gestão do programa um controle mais eficiente e uma compreensão mais profunda das interações dentro da comunidade, resultando em uma melhoria significativa na realização dos objetivos do programa e na ampliação do impacto gerado na comunidade de CEOs.

#### CEOs do Programa CEO’s Legacy:

&emsp;&emsp;Os membros da comunidade CEO’s Legacy, que são os principais usuários e beneficiários da plataforma, usam o LegacyLab para gerenciar seus projetos, identificar novas oportunidades de sinergia e colaborar de forma mais eficaz com seus pares. Para os CEOs, o LegacyLab não apenas facilita a gestão de suas iniciativas, mas também enriquece suas experiências dentro da comunidade, ampliando suas capacidades de liderança, e enriquecendo suas sinergias entre projetos.

#### Inteli (Instituto de Tecnologia e Liderança):

&emsp;&emsp;O Inteli, onde os alunos da equipe LegacyLab estudam, valoriza o projeto como uma concretização da sua metodologia de ensino. A colaboração com a FDC e a participação em um projeto real reforçam a parceria da Inteli com o mercado, promovendo a integração entre teoria e prática e consolidando sua reputação como uma instituição líder em educação tecnológica e de liderança.

#### Grupo LegacyLab:

&emsp;&emsp;O Grupo LegacyLab está encarregado por todo o desenvolvimento do projeto. Com a oportunidade única de parceria entre o Inteli e a FDC, o projeto é uma oportunidade excepcional para os alunos de aprendizado e aplicação de tecnologias em um contexto de impacto real, o que complementa a formação acadêmica e os prepara para o mercado.

&emsp;&emsp;Os CEOs, como usuários principais da plataforma, e a gestão do programa CEO’s Legacy, como responsáveis pela operação e sucesso do programa, são partes interessadas críticas cujas necessidades e expectativas devem ser priorizadas. A colaboração com a FDC e o Inteli, por sua vez, é essencial para garantir a integração e alinhamento do projeto com os objetivos e valores das instituições envolvidas. Por fim, o Grupo LegacyLab, como responsável pelo desenvolvimento do projeto, deve garantir que a solução atenda aos requisitos e expectativas de todas as partes interessadas, garantindo o sucesso do projeto e a satisfação de todos os envolvidos.

&emsp;&emsp;A identificação e compreensão das partes interessadas é fundamental para o sucesso do LegacyLab, pois permite que a equipe de desenvolvimento entenda as necessidades, expectativas e restrições de cada grupo e assegure que a solução atenda a esses requisitos. Ao considerar as perspectivas e interesses de todas as partes interessadas, a equipe pode garantir que a solução desenvolvida seja relevante, eficaz e bem-sucedida.

## 3.3 Proposta Tecnológica e Benefícios

&emsp;&emsp;Para o desenvolvimento do projeto que envolve a criação de uma plataforma interativa para CEOs no âmbito do "CEO Legacy" na Fundação Dom Cabral, a adoção de C# para o backend e React Native para o frontend é uma escolha tecnológica estratégica e bem fundamentada. Utilizando C#, uma linguagem robusta e escalável, o backend poderá gerenciar com agilidade as operações de banco de dados necessárias para manipular complexas interações e relacionamentos entre usuários, projetos e recomendações. A ferramenta Dapper, conhecida por sua eficiência em consultas SQL e mapeamento de dados, será utilizada para garantir que operações como o registro e a análise de interesses e sinergias entre executivos sejam realizadas de maneira rápida e confiável.

&emsp;&emsp;Adicionalmente, a utilização de serviços da Amazon AWS proporcionará uma infraestrutura flexível e escalável para hospedar a plataforma, oferecendo alta disponibilidade e segurança, além de permitir a fácil integração com outros serviços da AWS, como bancos de dados e armazenamento. No frontend, o React Native permitirá a criação de uma interface de usuário responsiva e nativa para múltiplas plataformas (iOS e Android), otimizando a experiência do usuário e reduzindo o tempo de desenvolvimento.

&emsp;&emsp;Para análise de dados, a adoção de Python em conjunto com a biblioteca pandas permitirá a manipulação eficiente de grandes volumes de dados e a execução de análises complexas. Esta combinação de tecnologias garantirá que o projeto seja não apenas eficiente e escalável, mas também capaz de evoluir rapidamente em resposta às mudanças nas demandas dos usuários e do mercado, mantendo-se tecnologicamente relevante e competitivo.

&emsp;&emsp;Essa combinação de tecnologias não apenas se alinha com os objetivos de proporcionar uma plataforma eficiente e intuitiva para os CEOs interagirem, mas também garante que o sistema possa escalar conforme o crescimento do programa "CEO Legacy". Além disso, o uso dessas tecnologias modernas reflete e promove os valores centrais do programa de colaboração, crescimento e inovação, fundamentais para o sucesso e impacto duradouro da iniciativa.

## 3.4 Proposta de Valor (*Value Proposition Canvas*)

&emsp;&emsp;O Canvas de Proposta de Valor, ou *Value Proposition Canvas*, é uma ferramenta fundamental no domínio da estratégia de negócios e inovação. Ele foi desenvolvido por Alexander Osterwalder, cujo trabalho mudou a forma que empresas estabelecidas fazem negócios e como novos empreendimentos são iniciados. Seu trabalho, auxilia empresas a entenderem as necessidades e desejos de seus clientes, bem como a criar produtos ou serviços que atendam a essas demandas de forma eficaz.

&emsp;&emsp;O Canvas de Proposta de Valor concentra-se especificamente na elaboração de propostas de valor sólidas, as quais são a essência de qualquer negócio bem-sucedido. Ao dividir a análise em dois componentes-chave, **o perfil do cliente** e a **proposta de valor do produto** desenvolvido, o Canvas oferece uma estrutura clara que ajuda as empresas a aprimorar seus produtos, definir estratégias de marketing e, em última análise, conquistar a satisfação do cliente e o sucesso nos negócios.

&emsp;&emsp;Nesse contexto, para aplicar o Canvas de Proposta de Valor ao desenvolvimento da solução LegacyLab se faz necessário entender a fundo o cenário em que o produto e o cliente estão inseridos. Assim, a análise do perfil do cliente (CEO´s Legacy) permite identificar suas necessidades, dores e desejos, como a busca por gestão eficiente e a mensuração das interações de CEOs, por exemplo. Em seguida, concentra-se na construção da Proposta de Valor da aplicação, descrevendo como ela pode atender a essas necessidades. A partir dessas análises, é destacado como a solução pode melhorar a experiência do usuário e aumentar a eficiência operacional da CEO´s Legacy. Dessa maneira, essa abordagem estruturada ajuda a equipe a alinhar o projeto às expectativas e demandas das partes interessadas, permitindo o desenvolvimento de uma solução verdadeiramente valiosa para todos.

<div align="center">
  <sub>Figura 1: Canvas de Proposta de Valor</sub>
  <img src="/docs/images/business/value-proposition-canvas.png" alt="Canvas de Proposta de Valor" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Como funciona o *Value Proposition Canvas*

&emsp;&emsp; O Canvas de Proposta de Valor é composto por dois principais elementos e suas sub-divisões:

#### 1. Segmentos de Cliente: 
- Parte que identifica informações essenciais sobre o cliente do projeto.

1.1 Trabalhos a serem realizados pelos clientes **(*Costumer Jobs*)**

- Essa seção se concentra em identificar as principais tarefas ou objetivos que o cliente (neste contexto, o CEO´s Legacy) está tentando alcançar ao usar o produto desenvolvido.

1.2 Dores enfrentadas pelos clientes **(*Pains*)**

- As dores dos clientes representam a listagem dos problemas, obstáculos ou frustrações que os clientes enfrentam ao tentar realizar seus trabalhos.

1.3 Ganhos percebidos pelos clientes **(*Gain Creators*)**

- Nessa seção, são abordados os benefícios ou resultados positivos que o cliente espera alcançar ao concluir seus trabalhos com sucesso. 

#### 2. Proposta de Valor:
- Descreve o produto que o LegacyLab deve ser. Agrega valor para cada segmento do cliente, explicando como eles atendem às necessidades e desejos específicos de forma diferenciada da concorrência.

2.1 Componentes mais importantes da solução **(*Products & Services*)**

- Seção que defineo os principais elementos ou características do  produto, os mesmos que agregam valor ao cliente.

2.2 Alívio das dores dos clientes **(*Pain Relivers*)**

- Nesta seção, há a descrição de como a solução ajuda a resolver ou aliviar as dores identificadas anteriormente pelo cliente.

2.3 Criação de ganhos para os clientes **(*Pain Relivers*)**

- O destaque dessa seção gira em torno dos benefícios ou ganhos que a oferta proporciona ao CEO´s Legacy, alinhados com as expectativas identificadas anteriormente. 

&emsp;&emsp;Nesse contexto e com base na imagem, é possível entender as características principais do produto. Assim, destaca-se a seção de dores do cliente, que permite a análise profunda sobre onde a solução deve atuar e quais problemas deve resolver. Assim, a seção "_Pain Relievers_" se conecta diretamente aos problemas enfrentados pelo público-alvo e fornece utilidades da solução que garantem precisamente sanar as questões enfrentadas, garantindo assim um projeto bem definido e com bases sólidas.

&emsp;&emsp;Portanto, é a partir de ferramentas como o Canvas que a equipe de desenvolvedores do LegacyLab pode ser altamente precisa e saber o que fazer e o que está fora do escopo. A clareza proporcionada pelo Canvas não só orienta o desenvolvimento do produto, mas também ajuda a estabelecer expectativas realistas e a evitar desvios desnecessários durante o processo de desenvolvimento.

## 3.5 Matriz de Risco

&emsp;&emsp;A matriz de risco é uma ferramenta utilizada para identificar e avaliar os riscos e oportunidades de um projeto. A matriz é dividida em quatro quadrantes, que representam a probabilidade e o impacto de cada risco ou oportunidade. Os riscos e oportunidades são classificados de acordo com a sua probabilidade de ocorrência e o impacto que podem causar no projeto.

&emsp;&emsp;Para garantir o sucesso do projeto de desenvolvimento da aplicação móvel voltada para networking entre CEOs, foi adotada uma abordagem proativa para indentificação de riscos e oportunidades. Os desenvolvedores do LegacyLab identificaram potenciais desafios, através de uma análise cuidadosa de impacto e probabilidade. Com essa abordagem abrangente, essa equipe de desenvolvedores se torna mais preparada para enfrentar os desafios que podem surgir e garantir o sucesso do projeto.

<div align="center">
  <sub>Figura 2: Matriz de riscos e oportunidades do projeto</sub>
  <img src="/docs/images/business/risk-matrix.png" alt="Matriz de Risco" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Riscos

#### 1. Ausência de integrantes
&emsp;&emsp;Risco de integrantes se ausentarem por motivos pessoais ou de saúde, impactando o andamento do projeto.

#### 2. Conflitos de equipe
&emsp;&emsp;Potenciais conflitos entre integrantes que podem afetar a colaboração e a produtividade.

#### 3. Atrasos nas entregas
&emsp;&emsp;Risco de não cumprir os prazos estabelecidos, resultando em atrasos nas entregas das tarefas.

#### 4. Curva de aprendizado técnico
&emsp;&emsp;Dificuldades dos integrantes no aprendizado das novas tecnologias requeridas pelo projeto, como [arquitetura SOA](#arquitetura-soa), sistema de recomendação e desenvolvimento *mobile*.

#### 5. Expectativas do parceiro
&emsp;&emsp;A possibilidade da solução desenvolvida não atender todas as expectativas iniciais do parceiro FDC.

#### 6. Implementação de requisitos
&emsp;&emsp;Risco de não conseguir implementar todos os requisitos levantados no início do projeto.

#### 7. Eficiência do sistema de recomendação
&emsp;&emsp;O sistema de recomendação com dados simulados pode não refletir a realidade complexa das interações entre os CEOs na comunidade do CEO´s Legacy.

### Oportunidades

#### 8. Otimização do trabalho da gestão
&emsp;&emsp;A solução pode economizar o tempo da gestão do CEO´s Legacy na administração de projetos e sinergias.

#### 9. Descoberta de sinergias
&emsp;&emsp;Potencial aumento na quantidade e valor das sinergias descobertas com o uso da solução.

#### 10. Desenvolvimento profissional dos integrantes
&emsp;&emsp;Oportunidade para os integrantes adquirirem conhecimentos técnicos e práticos sobre [arquitetura SOA](#arquitetura-soa), sistemas de recomendação e desenvolvimento mobile.

#### 11. Gestão aprimorada de sinergias
&emsp;&emsp;A solução pode melhorar significativamente a gestão e acompanhamento das sinergias para a comunidade CEO´s Legacy.

#### 12. Percepção de valor aumentada
&emsp;&emsp;O uso da solução pode aumentar a percepção de valor do programa CEO´s Legacy por parte dos CEOs participantes.

#### 13. Promoção do CEO's Legacy
&emsp;&emsp;A solução tem o potencial de promover o CEO´s Legacy, atraindo mais interessados e aumentando a visibilidade do programa.

&emsp;&emsp;A matriz de risco é uma ferramenta importante para o gerenciamento de riscos e oportunidades, permitindo que a equipe do projeto identifique, avalie os possíveis impactos e probabilidade de ocorrência de cada risco e oportunidade e tome medidas preventivas para minimizar os riscos e maximizar as oportunidades. Nesse sentido, destaca-se a oportunidade de gerar, a partir do desenvolvimento da solução, uma otimização do trabalho da gestão do cliente, trazendo qualidade e melhora significativa para o trabalho realizado pelo parceiro. Com isso, a equipe pode se preparar melhor para lidar com os desafios e garantir o sucesso da solução desenvolvida para o parceiro FDC.

## 3.6 Estimativa de Investimento

&emsp;&emsp;Ao desenvolver o aplicativo para gestão de sinergias entre empresas no âmbito do CEO's Legacy, a elaboração de uma estimativa de investimento precisa se torna crucial. Este planejamento financeiro garante a viabilidade do projeto e direciona a alocação eficiente de recursos. Dada a complexidade de integrar várias funcionalidades e a necessidade de colaboração entre diferentes lideranças, compreender os custos envolvidos é fundamental para o sucesso e sustentabilidade do projeto.

&emsp;&emsp;Nesta seção, abordaremos os principais aspectos que influenciam a estimativa de investimento para o nosso aplicativo, assegurando que todas as áreas críticas sejam contempladas e que o projeto prossiga com solidez financeira. É importante ressaltar que, a seguinte estimativa visa calcular o investimento de 12 meses, considerando o período entre o início do desenvolvimento e manutenção. Confira a seguir a descrição desses custos.

### Desenvolvedores

&emsp;&emsp;A equipe de desenvolvimento é essencial para construir, testar e manter o aplicativo. Eles são responsáveis pela codificação, integração de sistemas, correção de bugs, manutenções e atualizações futuras.

&emsp;&emsp;O custo depende do número de pessoal necessário, suas localizações geográficas, suas habilidades e a duração do projeto. Contando que o desenvolvimento inicial do aplicativo será feito por 5 desenvolvedores juniores, um desenvolvedor sênior e um *product owner* durante 10 semanas no Brasil, é possível fazer a seguinte estimativa para este período:
<div align="center">
  <sub>Tabela 1: Gastos desenvolvedores I</sub>

| Cargo | Salário Mensal | Período (meses) | Quantidade de Pessoas | Valor Total  |
|-------|----------------|-----------------|-----------------------|--------------|
| Desenvolvedor Júnior| R$ 4,1 mil | 2,5 | 5 | R$ 51,25 mil |
| Desenvolvedor Sênior| R$ 11 mil | 2,5 | 1 | R$ 27,5 mil |
| Product Owner      | R$ 11 mil | 2,5 | 1 | R$ 27,5 mil |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Somando esses valores, durante 2,5 meses seriam gastos R$ 106.250 com desenvolvedores. Para concluir esse custo, precisamos analisar os 9,5 meses seguintes, focados em atualizações e manutenções. Utilizando como estimativa um desenvolvedor sênior e dois desenvolvedores juniores para darem essa continuidade, podemos calcular o restante dos gastos da seguinte maneira:

<div align="center">
  <sub>Tabela 2: Gastos desenvolvedores II</sub>

| Cargo | Salário Mensal | Período (meses) | Quantidade de Pessoas | Valor Total  |
|-------|----------------|-----------------|-----------------------|--------------|
| Desenvolvedor Júnior| R$ 4,1 mil | 9,5 | 2 | R$ 77,9 mil  |
| Desenvolvedor Sênior| R$ 11 mil | 9,5 | 1 | R$ 104,5 mil |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Portanto, o valor gasto com desenvolvedores nos 9,5 meses seguidos do desenvolvimento inicial seria de R$ 182,4 mil. Então, juntando esses dois períodos, calculando os 12 meses completos, o investimento total com desenvolvedores utilizando essas estimativas seria em torno de **R\$ 288.650**.

>Acesse a seção ["Referências"](#referências) deste documento [clicando aqui](#referências) para vizualizar a fonte dos dados salariais.

### Infraestrutura

&emsp;&emsp;Ao desenvolver um aplicativo móvel, um dos aspectos críticos do planejamento é a estimativa de gastos relacionados à infraestrutura. Esses gastos abrangem todos os recursos tecnológicos necessários para suportar o desenvolvimento, implementação e operação contínua do aplicativo. No caso da estimativa de investimento da aplicação LegacyLab, foi considerado a utilização de serviços AWS.

- **Serviços AWS** - Utilizando a Amazon Web Services, o projeto se beneficia de uma infraestrutura de nuvem escalável e flexível. Isso inclui serviços como EC2 para computação e RDS para gerenciamento de bases de dados. Esses serviços permitem que o aplicativo se adapte facilmente ao crescimento do número de usuários e demanda de dados, com um modelo de pagamento conforme o uso, o que pode otimizar os custos em comparação com soluções locais.

&emsp;&emsp;Para calcular os gastos relacionados à instância EC2 e ao banco de dados RDS, é possivel utilizar a ferramenta da própria AWS. Essa ferramenta calcula o valor do custo com base na necessidade do projeto. No contexto do aplicativo LegacyLab, a tabela abaixo representa os gastos necessários para a execução da aplicação durante 12 meses:

<div align="center">
  <sub>Tabela 3: Gastos Serviços AWS</sub>

| Serviço | Preço mensal | Período (meses) | Quantidade | Valor Total  |
|---------|--------------|-----------------|------------|--------------|
| Instância EC2 | US$ 8,83 | 12 | 1 | US$ 105,96 |
| Banco de Dados RDS| US$ 204,40 | 12 | 1 | US$ 2.448,00 |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

> Clicando nos seguintes links, é possível visualizar a simulação de preço da [instância EC2](/docs/images/business/ec2-cost.png) e a simulação de preço do [banco de dados RDS](/docs/images/business/rds-cost.png)

&emsp;&emsp;Podemos observar que ao longo de um ano, o valor total do serviço da Amazon fica em US\$ 2.553,96. Traduzindo esse preço para o real, obtemos aproximadamente **R$ 13.178,43**

> **Nota:** O custo da infraestrutura foi determinado com base na cotação do dólar estabelecida em R$5,16 em 26 de abril de 2024. Estes valores estão sujeitos a flutuações cambiais.

### Valor Total

&emsp;&emsp;A conclusão da nossa análise detalhada sobre os investimentos necessários para o desenvolvimento e manutenção do aplicativo LegacyLab, revela um panorama financeiro bem planejado e estruturado. O cálculo de um investimento total de aproximadamente **R$ 301.828,43** para os primeiros 12 meses ilustra um comprometimento com a eficiência e a sustentabilidade econômica do projeto.

&emsp;&emsp;Importante ressaltar que, embora esses números forneçam uma base sólida para o planejamento inicial, eles estão sujeitos a variações devido a fatores como flutuações cambiais, mudanças nas tarifas de serviços da AWS e alterações nos salários. Portanto, é crucial manter uma abordagem flexível e iterativa ao planejamento financeiro, com revisões periódicas do orçamento para ajustar-se às realidades do mercado e às necessidades do projeto. 

# 4. Análise dos processos

&emsp;&emsp; A análise de processos é uma parte fundamental da gestão de processos de negócios (BPM) e é frequentemente usada em conjunto com a modelagem de processos de negócios para melhorar a eficiência e a eficácia dos processos organizacionais. Ao identificar áreas de melhoria e oportunidades de otimização, as organizações podem implementar mudanças que resultam em processos mais eficientes, redução de custos e melhorias na qualidade dos produtos e serviços.

## 4.1 Cadeia de Valor
&emsp;&emsp; A cadeia de valor é um modelo de negócios que descreve as atividades que uma organização realiza para criar valor para seus clientes. O modelo foi proposto por Michael Porter em seu livro "Competitive Advantage: Creating and Sustaining Superior Performance" e é amplamente utilizado em estratégia de negócios para identificar oportunidades de melhoria e otimização de processos.

&emsp;&emsp; No contexto da Fundação Dom Cabral, a cadeia de valor é composta por atividades-chave relacionadas à captação de novos CEOs, catalogação de processos, gerenciamento de projetos e gerenciamento de sinergia. A seguir, são apresentadas as atividades-chave de cada um e suas respectivas etapas.

### Captação de novos CEOs
&emsp;&emsp; A captação de novos CEOs é um processo de suma importância para a Fundação Dom Cabral, pois envolve a identificação e atração de líderes empresariais qualificados para participar do programa CEO's Legacy.

<div align="center">
  <sub>Tabela 4: Captação de novos CEOs</sub>

  | Etapa | Descrição |
  |-------|-----------|
  | Identificação de necessidades | CEO's Legacy identifica a necessidade de integrar um novos líderes ao programa |
  | Recrutamento | Procurar ativamente por candidatos qualificados através de fontes diversas, como redes sociais, eventos e contato com empresas / Procurar candidaturas e indicações enviadas por CEO's |
  | Triagem inicial | Avaliar candidaturas para identificar os candidatos que melhor atendem aos critérios estabelecidos e tem perfil correspondente com o Legacy |
  | Entrevistas | Realizar entrevistas para avaliar o projeto do candidato, além de suas habilidades técnicas e comportamentais |
  | Integração | Integrar os CEOs aprovados ao programa, fornecendo informações, orientações e suporte |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Catalogação de Processos

&emsp;&emsp; A catalogação de processos é um processo que envolve a identificação, documentação e organização de projetos relacionados ao CEO's Legacy. Através da catalogação, a Fundação Dom Cabral pode categorizar projetos e, por consequência, identificar sinergias e similaridades entre eles de forma facilitada.

<div align="center">
  <sub>Tabela 5: Catalogação de Processos</sub>

| Etapa | Descrição |
|-------|-----------|
| Entrada de novo micro tema | Registrar a entrada de um novo projeto que apresenta micro tema a ser catalogado, identificando sua área de aplicação e relevância para a organização |
| Identificação e pesquisa | Identificar os projetos existentes na organização que apresentam similaridade e podem ser associados |
| Associação com macro tema | Associar o novo micro tema a um macro tema já existente ou criar um novo macro tema, se necessário, para agrupar projetos relacionados |
| Documentação dos projetos | Documentar detalhadamente cada projeto associado ao novo micro tema, incluindo nome, descrição, objetivos e atividades |
| Atualização do catálogo | Inserir o novo micro tema e os projetos associados no catálogo da organização, finalizando o processo |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>


### Gerenciamento de Projetos

&emsp;&emsp; O gerenciamento de projetos, por parte da Fundação Dom Cabral, é uma atividade essencial para garantir a divulgação, continuidade e expansão dos projetos desenvolvidos pelos líderes filiados ao CEO's Legacy.

<div align="center">
  <sub>Tabela 6: Gerenciamento de Projetos</sub>
  
| Etapa | Descrição |
|-------|-----------|
| Iniciação | Definir e autorizar o início ou integração de um projeto, identificando sua finalidade, objetivo e tema |
| Divulgação | Promover o projeto entre os líderes e equipes envolvidas  no CEO's Legacy, permitindo a descoberta e colaboração de interessados |
| Execução | Desenvolver sinergias entre os projetos e  atualizar o progresso do projeto, garantindo a entrega dos resultados esperados |
| Encerramento | Finalizar o projeto, avaliar os resultados alcançados e identificar lições aprendidas para projetos futuros |
  
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>


### Gerenciamento de Sinergia 
&emsp;&emsp; O gerenciamento de sinergia é um processo que envolve a promoção, identificação e criação de colaboração entre líderes para maximizar os benefícios alcançados. Além disso, permite a divulgação e acompanhamento dos resultados obtidos com a colaboração entre os projetos.

<div align="center">
  <sub>Tabela 7: Gerenciamento de Sinergia</sub>
  
| Etapa | Descrição |
|-------|-----------|
| Identificação de projetos | Identificar projetos em que a colaboração entre CEOs pode trazer benefícios mútuos e sinergias |
| Avaliação de sinergia | Os próprios líderes analisam a viabilidade e os benefícios potenciais da colaboração entre os projetos selecionados |
| Alinhamento estratégico | Definir grau de sinergia entre os 3 níveis: <br> - Aprender, onde há troca de conhecimento e ideias entre os projetos; <br> - Integrar, onde há integração de alguns processos e atividades; <br> - Unificar, onde há junção total dos projetos |
| Monitoramento de resultados | Acompanhar os resultados da colaboração, identificar desafios e oportunidades de melhoria contínua |
| Avaliação pós-projeto | Avaliar os resultados da sinergia alcançada e identificar lições aprendidas para projetos futuros  |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>


## 4.2 Modelagem de Processos

&emsp;&emsp; A modelagem de processos é uma técnica usada para representar visualmente os processos organizacionais e identificar oportunidades de melhoria. Por exemplo, o BPMN (Business Process Model and Notation) é uma notação gráfica usada para modelar processos de negócios e é amplamente para melhorar a eficiência e a eficácia dos processos organizacionais.

&emsp;&emsp; Considerando o contexto da Fundação Dom Cabral, o processo utilizado para a modelagem na notaçao BPMN foi o de captação de novos clientes para o CEO's Legacy. A seguir, são apresentados os diagramas de processos para a prospecção ativa e reativa de captação de CEO's.

### Prospecção Ativa de Captação de Clientes
&emsp;&emsp; A prospecção ativa de captação de clientes é um processo que envolve a identificação e abordagem proativa de CEO's que tenham projetos ligados aos ideais da Fundação Dom Cabral e, mais especificamente, ao Legacy. Nesse processo, os gestores tomam a iniciativa de entrar em contato com potenciais clientes através de redes sociais, festivais ou por contato interno caso já haja parceria em algum nível.

<div align="center">
  <sub>Figura 3: Prospecção Ativa de Captação de  Clientes</sub>
  <img src="/docs/images/business/bpmn-active.jpeg" alt="Prospecção Ativa de Captação de Clientes" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Prospecção Reativa de Captação de Clientes
&emsp;&emsp; A prospecção reativa de captação de clientes é um processo que envolve a captação de novos CEO's que mostram interesse ou por sugestões de clientes atuais. Nesse processo, a Fundação Dom Cabral recebe o contato de CEO's interessados em participar do Legacy através de email ou por indicação e realiza o processo de qualificação e captação desses novos clientes.

<div align="center">
  <sub>Figura 4: Prospecção Ativa de Captação de Clientes</sub>
  <img src="/docs/images/business/bpmn-reactive.jpeg" alt="Prospecção Ativa de Captação de Clientes" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; Logo, conclui-se que a análise de processos em geral é uma etapa fundamental para a identificação de oportunidades de melhoria e otimização dos processos organizacionais. Visto que, a partir da listagem e diagramação, é possível identificar áreas de melhoria para a empresa.

# 5. Requisitos

&emsp;&emsp;Requisitos em um projeto de software descrevem as funcionalidades, condições e capacidades que um sistema deve possuir para satisfazer as necessidades e expectativas dos usuários e outras partes interessadas. Eles servem como um acordo fundamental entre desenvolvedores e clientes sobre o que o sistema deve fazer e como deve se comportar. Os requisitos são essenciais para orientar o desenvolvimento do software, ajudando a garantir que o produto final atenda às necessidades para as quais foi projetado.

## 5.1 Requisitos Funcionais
  
&emsp;&emsp;Requisitos funcionais descrevem as funcionalidades específicas que um sistema deve oferecer para atender às necessidades dos seus usuários. Eles são descritos em termos de comportamento do sistema, ou seja, o que o sistema deve fazer. Estes requisitos são essenciais para o desenvolvimento de software, pois orientam os desenvolvedores na criação de funcionalidades que cumpram os objetivos do projeto. Identificar e documentar corretamente os requisitos funcionais é crucial para o sucesso do desenvolvimento e para a satisfação do usuário final.

### RF-01: Login do CEO

- A aplicação deve permitir que CEOs façam login para acessar as funcionalidades do sistema.

#### Critérios de Aceitação

1. A aplicação deve autenticar o CEO usando e-mail e senha.
2. Após o login bem-sucedido, o CEO deve ter acesso ao menu de recomendações de projetos.
3. Em caso de falha no login, a aplicação deve exibir uma mensagem de erro apropriada.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 8: Testes do Requisito Funcional 01</sub>


| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Login bem-sucedido | CEO cadastrado com credenciais válidas. | O CEO insere suas credenciais e solicita login. | O CEO é autenticado e tem acesso ao menu de recomendações de projetos | O CEO está logado e pode acessar as funcionalidades do sistema. |
| Login incorreto | CEO usa credenciais inválidas. | O CEO insere credenciais erradas e tenta logar. | A aplicação exibe uma mensagem de erro de autenticação. | O CEO não está logado e pode tentar novamente. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-02: Cadastro e Exclusão de Projetos

- A aplicação deve permitir que CEOs cadastrem novos projetos e excluam projetos que não são mais necessários.

#### Critérios de Aceitação

1. O CEO deve ser capaz de cadastrar todos os detalhes relevantes para um novo projeto.
2. A exclusão de um projeto deve requerer a confirmação do CEO antes de concluir a ação.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 9: Testes do Requisito Funcional 02</sub>


| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Cadastro de Projeto | CEO logado e na área de gerenciamento de projetos. | O CEO clica no botão de adicionar para cadastrar um novo projeto e submete as informações requeridas. | O novo projeto é criado e listado na área de gerenciamento de projetos. | O projeto está disponível e pode ser visualizado ou editado pelo CEO. |
| Exclusão de Projeto | CEO visualiza a lista de seus projetos e seleciona um para exclusão. | O CEO clica em 'Excluir' em um projeto e confirma a ação na etapa de confirmação. | O projeto é removido da lista de projetos. | O projeto excluído não é mais listado. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-03: Visualizar Projetos Recomendados
- A aplicação deve permitir que CEOs visualizem projetos recomendados, alinhados com seu histórico de avaliações.

#### Critérios de Aceitação

1. A aplicação deve apresentar uma lista de projetos recomendados após o CEO logar-se.
2. As recomendações devem ser baseadas no histórico de avaliações do CEO.
3. O CEO deve poder navegar pelas recomendações e acessar detalhes adicionais de cada projeto.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 10: Testes do Requisito Funcional 03</sub>


| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Visualização de Recomendações  | CEO logado com histórico de avaliações.  | O CEO navega até o menu de recomendações de projetos. | A aplicação exibe uma lista de projetos recomendados. | O CEO pode explorar projetos recomendados e acessar detalhes adicionais caso queira. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-04: Visualizar Projetos por Macrotema

- A aplicação deve permitir que CEOs visualizem os projetos de maneira organizada por macrotema.

#### Critérios de Aceitação

1. CEOs devem ter acesso a um menu que categoriza projetos pelos macrotemas distintos.
2. Ao selecionar um macrotema, a aplicação deve exibir uma lista de projetos associados a esse macrotema.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 11: Testes do Requisito Funcional 04</sub>


| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Navegação por Macrotema | CEO logado e na tela de projetos do menu | O CEO seleciona um macrotema do menu. | A aplicação exibe todos os projetos associados ao macrotema escolhido. | O CEO pode visualizar e selecionar projetos para ver mais detalhes. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-05: Visualizar Informações de um Projeto Específico

- A aplicação deve permitir que CEOs visualizem informações detalhadas dos projetos, incluindo ações relacionadas a interesse e sinergias.

#### Critérios de Aceitação

1. CEOs devem poder visualizar detalhes como nome do projeto, empresa, CEO responsável e descrição.
2. CEOs devem ter a opção de avaliar seu nível de interesse no projeto.
3. CEOs devem ter a opção de cadastrar sinergias de um de seus próprios projetos com o projeto em questão.
4. CEOs devem ter a opção de visualizar as sinergias existentes associadas ao projeto.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 12: Testes do Requisito Funcional 05</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Detalhamento de Projeto | CEO logado e na tela de visualização de projetos. | O CEO seleciona um projeto para ver detalhes. | Os detalhes do projeto são exibidos, incluindo opções para interesse e sinergias. | CEO visualiza informações detalhadas do projeto e tem opções de interação disponíveis. |
| Opção para Avaliação do Interesse | CEO na tela de detalhes de um projeto. | O CEO localiza a opção para avaliar seu interesse. | A opção para iniciar o processo de avaliação de interesse é apresentada. | CEO pode iniciar o processo de avaliação de interesse no projeto. |
| Opção para Cadastro de Sinergia | CEO na tela de detalhes de um projeto. | O CEO localiza a opção para cadastrar sinergia. | A opção para iniciar o processo de cadastro de sinergia é apresentada. | CEO pode iniciar o processo de cadastro de sinergia com o projeto. |
| Opção para Visualização de Sinergias  | CEO na tela de detalhes de um projeto. | O CEO localiza a opção para visualizar sinergias. | A opção para iniciar o processo de visualização de sinergias é apresentada. | CEO pode iniciar o processo de visualização de sinergias existentes. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-06: Avaliar Interesse em um Projeto

- A aplicação deve oferecer uma funcionalidade para que CEOs possam avaliar seu nível de interesse em projetos específicos.

#### Critérios de Aceitação

1. O CEO deve ser capaz de avaliar seu interesse em um projeto em uma escala de 1 a 5.
2. Após a ação, a avaliação do CEO deve ser registrado no sistema.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 13: Testes do Requisito Funcional 06</sub>


| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Avaliar Interesse | CEO logado e visualizando um projeto. | O CEO executa a ação para avaliar seu interesse no projeto. | O sistema confirma a avaliação do CEO | A avaliação do usuário é registrado no banco de dados. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-07: Cadastro de Sinergia entre Projetos

- A aplicação deve permitir que CEOs cadastrem sinergias entre seus projetos e projetos de outros CEOs.

#### Critérios de Aceitação

1. CEOs devem poder selecionar um projeto de interesse do Legacy e formar uma sinergia o atrelando a um de seus próprios projetos.
2. Ao cadastrar a sinergia, o CEO deve selecionar o tipo de relação entre os projetos.
3. A sinergia cadastrada deve ser salva no sistema e acessível aos CEOs envolvidos.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 14: Testes do Requisito Funcional 07</sub>


| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Cadastro de Sinergia | CEO logado e visualizando projetos.  | O CEO seleciona um projeto que lhe interessou e escolhe um de seus próprios projetos para cadastrar a sinergia entre eles. | A sinergia é cadastrada no sistema e visível para os envolvidos. | Sinergia disponível para consulta pelos CEOs da Legacy. |
| Especificação de Sinergia | CEO identifica potencial sinergia com projeto de outro CEO.  | No cadastro, o CEO seleciona o tipo de sinergia e seleciona se ela é de aprendizado, integração ou unificação. | A sinergia é cadastrada com sua especificação no sistema e visível para os envolvidos. | Registro inicial e detalhado da sinergia para facilitar o entendimento e a gestão das relações entre projetos. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-08: Visualização do perfil

- A aplicação deve permitir que CEOs visualizem seu perfil, incluindo informações pessoais e uma lista de seus projetos cadastrados.

#### Critérios de Aceitação

1. CEOs devem poder visualizar suas informações pessoais atualizadas.
2. CEOs devem ter acesso a uma lista de seus projetos.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 15: Testes do Requisito Funcional 09</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Visualização de Perfil | CEO cadastrado na aplicação. | O CEO acessa sua aba de perfil. | As informações pessoais do CEO e a lista de projetos são exibidas.	| CEO revisa e confirma suas informações. |
| Visualização de Projetos | CEO logado e visualizando sua aba de perfil. | O CEO acessa a seção de projetos para visualizar a lista de seus projetos ativos. | A lista de projetos é exibida, incluindo detalhes como nome do projeto, status, e descrição breve de cada projeto. | CEO pode acompanhar andamento de seus projetos. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RF-09: Vizualização de Sinergias Cadastradas

- A aplicação deve permitir que CEOs visualizem todas as sinergias cadastradas envolvendo os projetos do Legacy.

#### Critérios de Aceitação

1. CEOs podem visualizar sinergias entre dois projetos quaisquer, podendo ser de seus próprios projetos ou de quaisquer outros da comunidade.

#### Descrição dos Testes
<div align="center">
  <sub>Tabela 16: Testes do Requisito Funcional 11</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Visualização de Sinergias	| CEO logado no sistema	| CEO visualiza página de detalhes de um projeto qualquer do Legacy | O CEO consegue visualizar sinergias de um projeto específico. | CEOs podem acompanhar sinergias da aplicação. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Dada a importância vital dos requisitos funcionais no desenvolvimento de software, é essencial que eles sejam meticulosamente identificados, documentados e compreendidos. Isso não só garante que o sistema final atenda às expectativas e necessidades específicas dos usuários, mas também minimiza riscos de mal-entendidos e retrabalhos. Além disso, uma definição clara de requisitos funcionais facilita a comunicação entre todas as partes envolvidas no projeto, desde os desenvolvedores até os stakeholders, e contribui para um processo de desenvolvimento mais ágil e eficiente. Portanto, investir tempo e recursos na correta especificação dos requisitos funcionais é investir na qualidade e no sucesso da aplicação LegacyLab.

## 5.2 Requisitos não Funcionais

&emsp;&emsp;Requisitos não funcionais são critérios cruciais que definem como um sistema deve operar, em contraste com o que ele deve fazer. Estes requisitos são fundamentais para assegurar a qualidade, eficiência e a experiência do usuário em um sistema de software. Eles abrangem uma ampla gama de aspectos, como qualidade de serviço, que estabelecem os padrões de operação sob diversas condições.

&emsp;&emsp;A ISO/IEC 25010, conhecida como SQuaRE (System and Software Quality Requirements and Evaluation), é uma norma internacional que desempenha um papel crucial na definição e categorização da qualidade de produtos de software e sistemas. Esta norma, criada pela Organização Internacional para Padronização (ISO) e pela Comissão Eletrotécnica Internacional (IEC), é essencial para orientar os desenvolvedores no processo de avaliação e garantia da qualidade dos produtos de software ao longo do seu ciclo de vida. Abaixo é possível analisar os requisitos propostos pelo grupo LegacyLab.

### RNF-01: Segurança e Privacidade
- A plataforma deve garantir a proteção de dados pessoais e corporativos em conformidade com as normas internacionais de segurança de dados, como a LGPD (Lei Geral de Proteção de Dados). Todas as transações de dados devem ser realizadas através de canais seguros.

&emsp;&emsp;**Iso Relacionada:** Segurança (Security), essencial para prevenir o acesso não autorizado ou vazamento de informações sensíveis.

#### Critérios de Aceitação
1. A aplicação deve estar em conformidade com a LGPD e outras normas de segurança de dados relevantes.
2. Implementar autenticação através de um serviço de autenticação que verifica credenciais do usuário e retorna um token de acesso seguro para uso em todas as outras requisições futuras.

#### Descrição dos Testes

<div align="center">
  <sub>Tabela 18: Teste de Segurança e Privacidade</sub>

| Nome | Pré-condição | Procedimentos | ResultadoEsperado | Pós-condição |
|------|--------------|---------------|-------------------|--------------|
| Conformidade com LGPD | Sistema implementado e operacional | Realizar uma auditoria para verificar a conformidade com a LGPD, incluindo procedimentos de coleta, armazenamento e compartilhamento de dados | A auditoria confirma que todos os processos estão em conformidade com a LGPD  | Manutenção contínua da conformidade com a LGPD         |
| Teste de Autenticação de Serviço de Autenticação | Sistema implementado e operacional | Inserir credenciais incorretas para autenticação no serviço intermediário | Acesso negado para credenciais incorretas, confirmando a eficácia da autenticação                           | Segurança reforçada nas comunicações internas          |
  
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RNF-02: Interface de usuário intuitiva

- O design da interface deve ser guiado pelas Heurísticas de Usabilidade de Nielsen, assegurando que o aplicativo seja fácil de usar e esteticamente agradável, minimizando a necessidade de treinamento extensivo.

&emsp;&emsp;**Iso Relacionada:** Usabilidade (Usability), crucial para garantir que todos os usuários possam interagir eficientemente com o aplicativo sem necessidade de treinamento prévio.

#### Critérios de Aceitação

1. A interface do usuário deve aderir a todas as 10 Heurísticas de Nielsen para usabilidade.
2. Testes com usuários devem mostrar que é possível realizar tarefas básicas de forma intuitiva sem instruções adicionais, com taxa de sucesso mínima de 80%.

#### Descrição dos Testes

<div align="center">
  <sub>Tabela 19: Teste da Interface do Usuário </sub>
 
| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
|Teste de Usabilidade Geral | Aplicativo instalado em dispositivos variados | CEOs diversos usam a aplicação de forma livre | Os usuários conseguem realizar tarefas sem dificuldades e relatam uma experiência positiva | O aplicativo é validado, podendo obter a taxa de sucesso mínima de 80% |

<sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RNF-03: Compatibilidade em diversos dispositivos

- O aplicativo deve ser compatível e otimizado para funcionar em uma ampla gama de dispositivos móveis, incluindo variados tamanhos de tela e diferentes sistemas operacionais como Android e iOS englobando suas versões dos últimos 5 anos.

&emsp;&emsp;**Iso Relacionada:** Compatibilidade (Compatibility), assegura que o aplicativo pode ser usado por um amplo espectro de usuários, aumentando assim sua acessibilidade e eficácia.

#### Critérios de Aceitação

1. O aplicativo deve funcionar de forma consistente e eficiente em dispositivos Android e iOS.
2. A interface deve ser responsiva e adaptar-se a diferentes tamanhos e resoluções de tela sem perder funcionalidade.

#### Descrição dos Testes

<div align="center">
  <sub>Tabela 20: Teste de Compatibilidade</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Teste de Compatibilidade com sistemas operacionais | Aplicativo desenvolvido para Android e iOS | Instalar e executar o aplicativo em versões atualizadas de Android e iOS | O aplicativo funciona corretamente em todas as versões testadas | Confirmação de operação adequada em múltiplos sistemas |
| Teste de Responsividade de Tela | Aplicativo com design responsivo | Testar o aplicativo em dispositivos com diferentes tamanhos de tela, de smartphones pequenos a tablets grandes | A interface do aplicativo ajusta-se adequadamente a todos os tamanhos de tela, mantendo a usabilidade | Usuários conseguem navegar na aplicação em variados tamanhos de tela  |

<sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RNF-04: Mantenabilidade

- O código do aplicativo deve ser escrito seguindo as melhores práticas de programação envolvendo sempre revisão por pelo menos um membro da equipe que não seja o próprio autor. Além disso, deve contar com documentação completa e clara, facilitando futuras atualizações e manutenção por outros desenvolvedores.

&emsp;&emsp;**Iso Relacionada:** Manutenção (Maintainability), facilita a gestão contínua e a evolução do software, assegurando que o aplicativo possa ser atualizado e corrigido com eficácia e eficiência.

#### Critérios de Aceitação

1. O código do aplicativo deve aderir a padrões de codificação reconhecidos e boas práticas de desenvolvimento.
2. Toda a base de código deve ser documentada de forma clara e compreensiva, incluindo comentários significativos e documentação externa.

#### Descrição dos Testes

<div align="center">
  <sub>Tabela 21: Teste de Mantenabilidade</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Revisão de Código | Código-fonte disponível para análise | Realizar revisões de código por pares, incluindo desenvolvedores que não participaram do desenvolvimento inicial | O código é considerado claro, bem organizado e aderente a padrões de codificação | Melhorias contínuas na base de código e facilitação de futuras revisões |
| Teste de Documentação	 | Documentação completa disponível | Avaliar a documentação do código por um desenvolvedor externo para verificar se está completa e compreensível | A documentação é adequada para permitir manutenção e atualizações sem confusão | Documentação permite que próximos desenvolvedores possam se interar com facilidade |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RNF-05: Escalabilidade

- O sistema deve ser projetado para suportar um volume de até 10.000 usuários simultâneos e um aumento no volume de dados sem comprometer o desempenho. Isto inclui a capacidade de escalar recursos de infraestrutura de forma dinâmica e automática conforme a demanda.	

&emsp;&emsp;**Iso Relacionada:** Flexibilidade (Flexibility), permite que o aplicativo cresça em termos de usuário e de carga de dados, assegurando a continuidade e a eficiência do serviço conforme o aumento das requisições.

#### Critérios de Aceitação

1. A capacidade do sistema de aumentar ou diminuir recursos automaticamente deve ser demonstrada em testes de carga escalonados até atingir 10.000 usuários simultâneos.
#### Descrição dos Testes

<div align="center">
  <sub>Tabela 22: Teste de Escalabilidade</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Teste de Carga	| Aplicativo em operação com número base de usuários | Incrementar o número de usuários e volume de dados gradualmente enquanto monitora performance e tempo de resposta | O aplicativo mantém performance aceitável conforme especificações, sem degradação significativa | Capacidade de escalabilidade do aplicativo confirmada |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RNF-06:  Interoperabilidade	

- O aplicativo deve suportar a troca de dados via APIs bem definidas e aderir a padrões de comunicação seguros para facilitar a interoperabilidade sem comprometer a segurança dos dados.	

&emsp;&emsp;**Iso Relacionada:** Compatibilidade (Compatbility), essencial para garantir que o aplicativo possa operar em conjunto com outros sistemas, ampliando sua utilidade e eficiência operacional.

#### Critérios de Aceitação

1. O aplicativo deve permitir a troca de dados de forma segura e eficiente com outros sistemas via APIs.

#### Descrição dos Testes

<div align="center">
  <sub>Tabela 23: Teste de Interoperabilidade</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Teste de Integração API | APIs externas disponíveis para conexão | Configurar e realizar a troca de dados entre o aplicativo e sistemas externos através das APIs | A troca de dados é bem-sucedida e as informações são precisas e seguras | Integração efetiva e segura com sistemas externos confirmada |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### RNF-07: Desempenho

- O sistema deve manter um alto nível de desempenho, assegurando que a taxa de resposta seja inferior a 2 segundos para 95% das transações, mesmo sob condições de carga máxima.

&emsp;&emsp;**Iso Relacionada:** Eficiência de Desempenho (Performance Efficiency), garantindo que o sistema seja capaz de responder de forma rápida e eficiente, mesmo sob condições de alta demanda, para proporcionar uma experiência de usuário consistente e satisfatória.

#### Critérios de Aceitação

1. O tempo de resposta das transações deve ser inferior a 2 segundos para 95% das transações durante testes de carga máxima.
2. Este desempenho deve ser mantido independentemente da complexidade da transação ou do volume de dados envolvido em cada operação.

#### Descrição dos Testes

<div align="center">
  <sub>Tabela 24: Teste de Desempenho</sub>

| Nome | Pré-condição | Procedimentos | Resultado Esperado | Pós-condição |
|------|--------------|---------------|--------------------|--------------|
| Teste de Tempo de Resposta	| Sistema operacional e com acesso a banco de dados de teste populado. | Executar um teste de carga com 10.000 usuários simultâneos, simulando transações variadas em complexidade e volume de dados.	 | 95% das transações devem ter um tempo de resposta inferior a 2 segundos, mesmo sob condições de carga máxima.	 | Usuário navega com fluidez e satisfação na aplicação. |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>


&emsp;&emsp;Em suma, enquanto os requisitos funcionais definem o que um sistema deve fazer, os requisitos não funcionais detalham como o sistema deve funcionar e se comportar. No contexto específico desta aplicação, os RNFs são cruciais para assegurar que o aplicativo não apenas facilite o registro e a interação entre projetos de CEOs, conforme as funções desejadas, mas também opera de maneira eficiente e segura em diferentes dispositivos e situações. Além disso, esses requisitos ajudam a garantir que a plataforma seja intuitiva e acessível, maximizando a adesão dos usuários e a utilidade prática do aplicativo no ambiente empresarial voltado para a inovação e colaboração entre líderes de negócios.

## 5.3 Casos de Uso
&emsp;&emsp;Os casos de uso são uma técnica de modelagem de requisitos que descreve as interações entre os usuários e o sistema, representando as funcionalidades que o sistema deve oferecer. Cada caso de uso descreve uma sequência de ações que o usuário pode realizar no sistema, visando atingir um determinado objetivo. Os casos de uso são uma ferramenta importante para a definição dos requisitos do sistema, pois permitem que a equipe de desenvolvimento entenda as necessidades dos usuários e priorize as funcionalidades de acordo com o valor que cada uma agrega ao negócio.

### 5.3.1 User Stories

&emsp;&emsp;As User Stories são uma técnica de documentação de requisitos ágil, que descreve as funcionalidades de um sistema de forma simples e direta, do ponto de vista do usuário. Cada User Story é uma pequena narrativa que descreve uma funcionalidade específica do sistema.

&emsp;&emsp;A seguir, são apresentadas as User Stories levantadas para o projeto LegacyLab, que descrevem as funcionalidades essenciais do sistema, do ponto de vista dos usuários CEOs da comunidade CEO´s Legacy.

**User Story 1: Sistema de login**
<div align="center">
  <sub>Tabela 25: User Stories 1</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US001</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Sistema de login</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF001: Login do CEO</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder fazer login na plataforma para acessar as funcionalidades exclusivas disponíveis para mim.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        - Deve existir uma página de login acessível para o CEO. <br>
        - Deve ser possível autenticar o CEO usando credenciais válidas. <br>
        - Após o login bem-sucedido, o CEO deve ser redirecionado para a página inicial da plataforma.
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Alta</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 2: Cadastro de novo projeto**
<div align="center">
  <sub>Tabela 26: User Stories 2</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US002</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Cadastro de novo projeto</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF002: Cadastro, edição e exclusão de projetos</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder cadastrar novos projetos na plataforma para compartilhar informações relevantes com outros líderes.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        - Deve existir um formulário de criação de projetos <br>
        - O formulário deve permitir a inserção de informações importantes <br>
        - Após o cadastro, o novo projeto deve ser exibido no perfil e no feed.
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Alta</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 3: Remoção de projetos**
<div align="center">
  <sub>Tabela 27: User Stories 3</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US003</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Remoção de projetos</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF002: Cadastro e exclusão de projetos</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder excluir projetos da plataforma para manter a lista apenas com projetos relevantes.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        - Deve existir uma opção de exclusão disponível em cada projeto listado no perfil <br>
        - Ao excluir um projeto, o CEO deve ser solicitado a confirmar a ação <br>
        - Após confirmar, o projeto selecionado deve ser removido e não deve mais ser visível para outros líderes
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Média</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 4: Feed personalizado por recomendação**
<div align="center">
  <sub>Tabela 28: User Stories 4</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US004</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Feed personalizado por recomendação</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF003: Visualizar projetos recomendados</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder visualizar projetos com base nos meus interesses para explorar oportunidades de colaboração.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        - O feed inicial deve recomendar projetos com base nas interações prévias do usuário.
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Alta</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 5: Filtragem de projetos por categoria**
<div align="center">
  <sub>Tabela 29: User Stories 5</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US005</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Filtragem de projetos por categoria</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF004: Buscar projetos por macrotema e microtema</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder buscar projetos por macrotema e microtema para encontrar iniciativas alinhadas aos objetivos estratégicos da minha empresa.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        - Deve existir uma tela que permita ao usuário selecionar um macrotema específico <br>
        - Os resultados da busca podem ser filtrados por microtemas
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Média</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 6: Visualizar informações de projetos**
<div align="center">
  <sub>Tabela 30: User Stories 6</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US006</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Visualizar informações de projetos</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF005: Visualizar informações de um projeto específico</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder visualizar informações detalhadas de um projeto específico para descobrir potenciais sinergias.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        - Todas as informações relevantes do projeto devem estar dispostas na tela <br>
        - Deve ser possível visualizar líderes interessados e sinergias já existentes
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Alta</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 7: Demonstrar interesse em um projeto**
<div align="center">
  <sub>Tabela 31: User Stories 7</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US007</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Demonstrar interesse em um projeto</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF006: Demonstrar interesse em um projeto</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder demonstrar interesse em um projeto para poder favoritá-lo e acompanhar suas atualizações.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        - Deve existir uma opção para o CEO demonstrar interesse em um projeto específico <br>
        - O sistema deve registrar o interesse demonstrado e notificar o proprietário do projeto sobre essa interação
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Média</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 8: Cadastrar sinergia de um projeto**
<div align="center">
  <sub>Tabela 32: User Stories 8</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US008</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Cadastrar sinergia de um projeto</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF007: Cadastrar sinergia de um projeto com outro</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder cadastrar sinergias entre projetos para identificar oportunidades de colaboração e alavancar recursos compartilhados.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        Deve ser possível cadastrar uma nova sinergia dentro de um projeto.
        As sinergias cadastradas devem ser exibidas de forma clara e acessível.
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Alta</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 9: Visualizar perfil próprio**
<div align="center">
  <sub>Tabela 33: User Stories 9</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US009</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Visualizar perfil próprio</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF009: Visualizar perfil (informações próprias e projetos próprios)</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder visualizar meu perfil para conseguir ter uma visão geral dos meus projetos.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        Deve existir uma seção de perfil onde o CEO possa visualizar suas informações pessoais.
        O perfil também deve exibir uma lista de projetos cadastrados.
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Alta</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 10: Visualizar sinergias cadastradas**
<div align="center">
  <sub>Tabela 34 User Stories 10</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US010</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Visualizar sinergias cadastradas</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF011: Visualizar sinergias cadastradas</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder visualizar separadamente projetos que tenham sinergia cadastrada comigo para ter fácil acesso a eles.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        Deve existir uma seção na plataforma para "Visualizar Sinergias".
        Os projetos nos quais o CEO cadastrou sinergia devem ser exibidos nesta seção.
        Deve ser possível ir para a página do projeto ao clicar.
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Baixa</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

**User Story 11: Adicionar atualização na sinergia**
<div align="center">
  <sub>Tabela 35: User Stories 11</sub>
  <table>
    <tr>
      <th><strong>Número</strong></th>
      <td>US011</td>
    </tr>
    <tr>
      <th><strong>Título</strong></th>
      <td>Adicionar atualização na sinergia</td>
    </tr>
    <tr>
      <th><strong>Requisito funcional relacionado</strong></th>
      <td>RF012: Adicionar atualização na sinergia</td>
    </tr>
    <tr>
      <th><strong>História</strong></th>
      <td>Como CEO, quero poder adicionar atualizações nas sinergias cadastradas para manter os usuários informados sobre o progresso da colaboração.</td>
    </tr>
    <tr>
      <th><strong>Critérios de aceitação</strong></th>
      <td>
        Deve existir uma opção para o CEO adicionar atualizações nas sinergias cadastradas.
        As atualizações devem ser visíveis para todos os usuários na página do projeto.
      </td>
    </tr>
    <tr>
      <th><strong>Prioridade</strong></th>
      <td>Média</td>
    </tr>
  </table>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>


### 5.3.2 Diagrama de Casos de Uso

&emsp;&emsp; O diagrama de casos de uso a seguir ilustra as principais funcionalidades do sistema LegacyLab, divididas em três grupos: Autenticação, Exploração de Projetos e Interação entre Projetos. Cada grupo contém um conjunto de User Stories relacionadas, que descrevem as interações entre os usuários e o sistema.

<br>

#### Gestão de Projetos

&emsp;&emsp; O grupo de casos de uso de Gestão de Projetos inclui as funcionalidades relacionadas ao login dos usuários, cadastro e remoção de projetos e visualização de perfil próprio. Essas funcionalidades são essenciais para a interação dos CEOs com a plataforma e para o gerenciamento de seu perfil e projetos.

<div align="center">
  <sub>Figura 5: Caso de Uso de Gestão de Projetos</sub>
  <img src="/docs/images/business/use-cases-diagram-1.png" alt="Caso de Uso de Gestão de Projetos" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>
<br>

#### Exploração e Visualização de Projetos

&emsp;&emsp; O grupo de casos de uso de Exploração e Visualização de Projetos inclui as funcionalidades relacionadas à visualização de projetos utilizando sistema de recomendação, filtragem de projetos por categoria e visualização de informações detalhadas de cada projeto. Essas funcionalidades permitem que os CEOs explorem e descubram novas oportunidades de colaboração na plataforma.

<div align="center">
  <sub>Figura 6: Caso de Uso de Exploração e Visualização de Projetos</sub>
  <img src="/docs/images/business/use-cases-diagram-2.png" alt="Caso de Uso de Exploração e Visualização de Projetos" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<br>

#### Interação entre Projetos

&emsp;&emsp; O grupo de casos de uso de Interação entre Projetos inclui as funcionalidades relacionadas à interação entre usuários dentro do LegacyLab, como demonstrar interesse em um projeto, cadastrar sinergias entre projetos e adicionar atualizações nas sinergias cadastradas. Essas funcionalidades permitem que os CEOs se envolvam ativamente na comunidade e colaborem de forma eficaz com outros líderes.

<div align="center">
  <sub>Figura 7: Caso de Uso de Interação com Outros Usuários</sub>
  <img src="/docs/images/business/use-cases-diagram-3.png" alt="Caso de Uso de Interação com Outros Usuários" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

## 5.4 Casos de Uso x Requisitos Funcionais

&emsp;&emsp;Os casos de uso e os requisitos funcionais estão diretamente relacionados, pois os casos de uso descrevem as interações entre os usuários e o sistema, enquanto os requisitos funcionais especificam as funcionalidades que o sistema deve oferecer. Abaixo, estão as relações entre os casos de uso e os requisitos funcionais levantados para o projeto.

<div align="center">
  <sub>Tabela 36: Caso de Uso x RF </sub>

| Diagrama de Casos de Uso | User Stories | Requisitos Funcionais |
|--------------------------|--------------|-----------------------|
| Gestão de Projetos | - US001: Sistema de login <br> - US002: Cadastro de novo projeto <br> - US003: Remoção de projetos <br> - US009: Visualizar perfil próprio| - RF001: Login do CEO <br> - RF002: Cadastro e exclusão de projetos  <br> - RF008: Visualização de perfil |
| Exploração e Visualização de Projetos | - US004: Feed personalizado por recomendação <br> - US005: Filtragem de projetos por categoria <br> - US006: Visualizar informações de projetos <br> - US010: Visualizar sinergias cadastradas | - RF003: Visualizar projetos recomendados <br> -RF004: Buscar projetos por macrotema e microtema <br> - RF005: Visualizar informações de um projeto específico <br> - RF010: Visualizar sinergias cadastradas |
| Interação com outros usuários | - US007: Demonstrar interesse em um projeto <br> - US008: Cadastrar sinergia de um projeto <br> - US011: Adicionar atualização na sinergia | - RF006: Demonstrar interesse em um projeto <br> - RF007: Cadastrar sinergia de um projeto com outro <br> - RF011: Adicionar atualização na sinergia |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

# 6. Projeto de Solução
&emsp;&emsp;Nesta seção, apresentaremos de forma detalhada o projeto da solução proposta para a criação do aplicativo para gestão de sinergias dos projetos das empresas do CEOs' Legacy. O objetivo é fornecer uma visão clara e abrangente de todos os aspectos técnicos e metodológicos que compõem a solução, garantindo que todas as partes envolvidas compreendam o funcionamento e a implementação do projeto.

## 6.1 Diagrama de Classes

&emsp;&emsp;Um **diagrama de classe de domínio** é um componente da modelagem de sistemas de informação utilizado principalmente na metodologia de desenvolvimento de software orientada a objetos. Esse diagrama apresenta as entidades (ou classes) relevantes do domínio do problema e as relações entre elas. As classes são tipicamente definidas por seus nomes, atributos (ou propriedades) e métodos (ou operações). A ideia é mapear de forma abstrata e visual os conceitos e interações que existem no domínio de negócio que o software pretende endereçar.

<div align="center">
  <sub>Figura 8: Diagrama de classe do projeto</sub>
  <img src="/docs/images/system/class-diagram.png" alt="Diagrama de classe" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Relações em Diagramas de Classe

&emsp;&emsp;Em um diagrama de classe, as relações entre as entidades são representadas por linhas que ligam as classes. Existem vários tipos de relações, cada uma com um significado específico:

### Relações N para N (Muitos-para-Muitos)

- Uma relação **n para n** ou **muitos-para-muitos** ocorre quando vários objetos de uma classe podem estar relacionados a vários objetos de outra classe. Por exemplo, em um sistema de cursos online, um estudante pode se inscrever em muitos cursos, e um curso pode ter muitos estudantes inscritos. Para modelar essa relação em um banco de dados relacional, geralmente criamos uma tabela de associação (ou junção) que contém chaves estrangeiras que apontam para as duas classes envolvidas.

### Relações N para 1 (Muitos-para-Um)

- Uma relação **n para 1** ou **muitos-para-um** indica que muitos objetos de uma classe estão associados a um único objeto de outra classe. Por exemplo, muitos pedidos podem estar associados a um único cliente. Neste caso, a classe "Pedido" teria um atributo que é a chave estrangeira referenciando a classe "Cliente".

### Relações 1 para N (Um-para-Muitos)

- Inversamente, uma relação **1 para n** ou **um-para-muitos** é simplesmente a perspectiva oposta de uma relação muitos-para-um, onde um objeto de uma classe está relacionado a muitos objetos de outra classe. No exemplo anterior, do ponto de vista do "Cliente", ele teria uma relação um-para-muitos com "Pedidos".

&emsp;&emsp;Com base no diagrama de classes fornecido, vamos documentar as relações entre as classes, focando na cardinalidade, navegabilidade e papel.

### Relação entre Category e SubCategory
- **Cardinalidade:** 1 para N (um-para-muitos)
- **Navegabilidade:** Bidirecional
- **Papel:**
  - **Category:** Define uma categoria geral para os projetos.
  - **SubCategory:** Representa uma especificação ou segmentação dentro de uma categoria geral.

### Relação entre Project e SubCategory
- **Cardinalidade:** N para 1 (muitos-para-um)
- **Navegabilidade:** Bidirecional
- **Papel:**
  - **Project:** Pertence a uma subcategoria específica e, por extensão, à categoria pai da subcategoria.
  - **SubCategory:** Agrupa projetos relacionados sob um mesmo tema específico.

### Relação entre Executive e Project através de Interest
- **Cardinalidade:** N para N (muitos-para-muitos)
- **Navegabilidade:** Bidirecional
- **Papel:**
  - **Interest:** Associa executivos a projetos que despertam seu interesse, com data e referência a ambos.
  - **Executive:** Pode expressar interesse em vários projetos.
  - **Project:** Pode atrair o interesse de vários executivos.

### Relação entre Executive e Project através de Synergy
- **Cardinalidade:** N para N (muitos-para-muitos)
- **Navegabilidade:** Bidirecional
- **Papel:**
  - **Synergy:** Registra a existência de sinergias potenciais entre executivos e projetos, com data e referência a ambos.
  - **User:** Pode identificar sinergias em vários projetos.
  - **Project:** Pode ter sinergias com vários executivos.

### Relação entre Project e Recommendation:
   - **Cardinalidade:** 1 para N (um-para-muitos)
   - **Navegabilidade:** Unidirecional do projeto para recomendações.
   - **Papel:** Cada projeto pode ter várias recomendações associadas a ele. A tabela "Recommendation" armazenaria detalhes como score, data e status, que são específicos para cada recomendação feita em relação a um projeto.


### Relação entre User e Recommendation:
   - **Cardinalidade:** N para N (muitos-para-muitos)
   - **Navegabilidade:** Bidirecional
   - **Papel:** Os usuários podem gerar ou receber várias recomendações, e cada recomendação pode estar ligada a vários usuários, seja como recomendantes ou recomendados. Essa relação mostra que tanto a emissão quanto o recebimento de recomendações são aspectos importantes das interações dos usuários com o sistema. 


### Relação entre Synergy e Updates
- **Cardinalidade:** 1 para N (um-para-muitos)
- **Navegabilidade:** Unidirecional (de Synergy para Updates)
- **Papel:**
  - **Synergy:** Uma instância de sinergia pode ter vários comentários associados a ela.
  - **Update:** Fornece observações ou detalhes adicionais sobre o andamento de uma sinergia específica.

### Notas Adicionais sobre Navegabilidade
- **Bidirecional:** Significa que a associação entre as classes pode ser explorada em ambas as direções. Por exemplo, a partir de uma subcategoria, pode-se encontrar todos os projetos relacionados e vice-versa.
- **Unidirecional:** Indica que a relação só pode ser navegada em uma direção. No caso de "Synergy" para "Updates", pode-se acessar os comentários a partir de uma sinergia, mas não se pode identificar a sinergia a partir de um comentário.

### O que são Operações em Diagramas de Classe?

&emsp;&emsp;Em diagramas de classe, operações (também conhecidas como métodos ou funções) são as ações ou comportamentos que uma classe pode realizar. Elas definem a funcionalidade que pode ser executada sobre os objetos dessa classe. As operações são declaradas dentro das classes e podem manipular os atributos da classe ou interagir com outras classes. Por exemplo, uma operação pode incluir cálculos, atualizações de dados, validações de informações, ou a invocação de outras operações.

&emsp;&emsp;Essas operações são essenciais para definir o comportamento dinâmico dos objetos dentro do sistema e são fundamentais para a implementação da lógica de negócio no código-fonte. Em um diagrama de classe, as operações são listadas na parte inferior da caixa da classe, normalmente abaixo dos atributos, e são descritas com sua assinatura, incluindo o nome da operação, os parâmetros que aceita, e o tipo de retorno esperado.

&emsp;&emsp;Cada classe e relação no diagrama serve a um propósito específico dentro do domínio de negócio do aplicativo "LegacyLab", e a documentação clara dessas relações é fundamental para a compreensão e desenvolvimento eficaz do sistema.

## 6.2 Arquitetura da Solução

&emsp;&emsp;A arquitetura da solução é uma etapa fundamental no desenvolvimento de um sistema de software, pois define a estrutura e os componentes do sistema, bem como as relações entre eles. Para o projeto LegacyLab, a arquitetura definida é baseada na [arquitetura orientada a serviços (SOA)](#arquitetura-soa), que é um estilo arquitetural que permite a criação de sistemas modulares e flexíveis, através da definição de serviços independentes e reutilizáveis.

<div align="center">

  <sub>Figura 9: Arquitetura da Solução</sub>
  <img src="/docs/images/system/architecture.jpeg" alt="Arquitetura da Solução" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 1. Frontend Mobile:

&emsp;&emsp;É a interface pela qual os CEOs interagem com o aplicativo. Este componente é responsável por apresentar a interface gráfica, capturar ações do usuário e comunicar-se com os serviços do backend por meio do Serviço Intermediário.

&emsp;&emsp;O frontend transforma as solicitações do usuário em chamadas de API e exibe os dados recebidos de forma coerente e amigável ao usuário, proporcionando uma experiência fluida e intuitiva.

#### 2. Serviço Core:

&emsp;&emsp;Este serviço gerencia todas as informações relacionadas aos projetos, incluindo interações como demonstrar interesse e criar sinergias. Ele processa solicitações de criação, visualização, atualização e exclusão de projetos, além de registrar e gerenciar as sinergias e interesses, operando diretamente com o banco de dados para manter os dados dos projetos e interações precisos e atualizados. Além disso, o serviço também é responsável por fornecer os dados pessoais do usuário.

#### 3. Serviço de Autenticação:

&emsp;&emsp;Fornece funcionalidades de autenticação para os usuários do sistema. Este serviço é responsável por gerenciar o processo de login com a validação das credenciais e a geração de tokens de acesso para autenticação.

#### 4. Serviço de Recomendação:

&emsp;&emsp;Fornece recomendações personalizadas aos CEOs. O serviço funciona de forma autônoma, utilizando um sistema de recomendação de filtragem colaborativa para sugerir projetos relevantes com base no histórico de interações dos usuários. Ele acessa o banco de dados para obter os dados necessários e armazena as previsões geradas diretamente no banco, facilitando a consulta destas previsões pelo Serviço de Projeto sem a necessidade de requisições frequentes ao serviço de recomendação.

#### 5. Banco de Dados:

&emsp;&emsp;Armazena de forma segura e centralizada todos os dados utilizados e gerados pelos serviços. É acessado pelos serviços de Usuário, Projeto e Recomendação para recuperação e armazenamento de dados, garantindo a integridade e segurança das informações.

#### 6. Serviço Externo - OpenAI:

&emsp;&emsp;Este serviço externo é utilizado para a geração de textos com base em modelos de linguagem de inteligência artificial. O serviço é acessado pelo Serviço Core para obter sugestões de descrições de projetos com base em informações fornecidas pelos CEOs. A integração com o serviço OpenAI permite a geração de descrições de projetos de forma automatizada e eficiente, melhorando a experiência do usuário e a qualidade das informações apresentadas.

&emsp;&emsp;A escolha da [arquitetura SOA](#arquitetura-soa) para o LegacyLab se alinha com os objetivos do projeto, permitindo a criação de um sistema modular, flexível e escalável. A separação dos serviços em componentes independentes facilita o desenvolvimento, a manutenção e a evolução do sistema, além de permitir a reutilização de serviços em diferentes contextos. Os serviços representam os principais aspectos funcionais do sistema, como a gestão de usuários, projetos e o modelo de recomendação, e são responsáveis por fornecer as funcionalidades necessárias para a operação do aplicativo.

&emsp;&emsp;Dentro do paradigma da arquitetura orientada a serviços, foi planejada uma arquitetura que não apenas promove a separação de serviços e a modularidade, mas também respeita a natureza interconectada do problema proposto pelo parceiro Fundação Dom Cabral. Dado o escopo do projeto e as interdependências das informações manipuladas, optou-se por uma estrutura onde, apesar de divididos, os serviços compartilham o acesso a um banco de dados centralizado. Essa decisão reflete uma adaptação prática à natureza do projeto, onde a separação completa de cada serviço em seu próprio banco de dados não seria a mais eficaz. Assim, enquanto os serviços são modularmente desenvolvidos, eles permanecem interconectados em nível de dados, o que otimiza o desempenho e a gestão das operações. Dessa maneira a arquitetura proposta para o LegacyLab é uma solução equilibrada que combina a modularidade e a eficiência necessárias para o sucesso do projeto.

&emsp;&emsp;Essa etapa de desenvolvimento da arquitetura da solução é fundamental para garantir que todos os requisitos funcionais e não funcionais especificados sejam atendidos de forma eficaz e eficiente. A partir da arquitetura definida, a equipe pode avançar para o desenvolvimento dos serviços e a integração dos componentes, garantindo que a solução atenda às expectativas e necessidades dos usuários e de todas as partes interessadas.

## 6.3 Diagrama de Implantação

&emsp;&emsp;O diagrama de implantação é uma ferramenta fundamental no desenvolvimento de software, especialmente útil para visualizar a configuração física dos artefatos em uma arquitetura de sistema. Utilizando a notação da *Unified Modeling Language* (UML), este diagrama descreve como um sistema é tecnicamente estruturado em termos de hardware e software, mostrando a disposição dos servidores de aplicação, a localização do banco de dados, e as interações entre clientes móveis e serviços em nuvem.

&emsp;&emsp;A clareza proporcionada pelo diagrama de implantação permite planejar adequadamente a alocação e configuração dos recursos tecnológicos. Os componentes do sistema estão agrupados em um único servidor EC2, que hospeda os diferentes serviços da aplicação, com um banco de dados PostgreSQL centralizado no AWS RDS. Essa abordagem reduz os custos de infraestrutura e simplifica a configuração, porém, à medida que a demanda aumenta, a infraestrutura pode evoluir para uma arquitetura de múltiplas instâncias EC2, permitindo que cada serviço seja escalado individualmente. A seguir vamos abordar os principais servidores da aplicação.

### Servidores de Aplicação

&emsp;&emsp;Dado que estamos utilizando uma arquitetura SOA, o projeto está dividido em diferentes serviços, todos hospedados em um único ambiente. Os serviços principais são:

**1. Clientes Móveis**
- Tecnologia: React Native
- Plataformas: Android e iOS
- Responsabilidade: Interface do usuário para interagir com os serviços via chamadas API.
- Conexão: Comunica diretamente com o servidor EC2, enviando e recebendo dados para operações de usuário e gestão de projetos via REST.

**2. Serviço de Autenticação**
- Tecnologia: C#
- Responsabilidade: Autenticação dos usuários através de tokens. 
- Hospedagem: AWS EC2 única, compartilhada com outros serviços.


**3. Serviço Core**
- Tecnologia: C#
- Responsabilidade: Gerenciamento de usuários e projetos cadastrados.
- Hospedagem: AWS EC2 única, compartilhada com outros serviços.

**4. Serviço de Recomendação**
- Tecnologia: Python
- Responsabilidade: Análise de dados para fornecer recomendações de projetos com base em heurísticas definidas.
- Hospedagem: AWS EC2 única, compartilhada com outros serviços.

**5. Serviço de API Externa**
- Tecnologia: OpenAI GPT API
- Responsabilidade: A API do GPT recebe um texto curto inserido pelo CEO e gera uma descrição detalhada e coerente, ajudando a melhorar a qualidade das descrições de projetos.
- Conexões: Integrada diretamente ao Serviço Core para fornecer descrições detalhadas sobre os projetos. Recebe inputs do serviço para personalizar as sugestões de texto com base no perfil e histórico do usuário.

**6. Banco de Dados**
- Tecnologia: PostgreSQL
- Serviço: AWS RDS
- Responsabilidade: Armazenar dados de usuários, projetos e recomendações de maneira centralizada, permitindo consultas eficientes e integridade dos dados.
- Conexões: Conectado diretamente aos Serviços de Autenticação e Core para operações de dados. Recebe inputs do Serviço de Recomendação para atualizar as sugestões.

**Arquitetura Final**
- A arquitetura final é composta por uma única instância EC2 hospedando os três serviços principais (Autenticação, Core e Recomendação) e um banco de dados PostgreSQL na AWS RDS. O aplicativo móvel comunica-se com os serviços via REST, e a autenticação é feita por meio de tokens gerenciados pelo Serviço de Autenticação.

<div align="center">
  <sub>Figura 10: Diagrama de Implantação</sub>
  <img src="/docs/images/system/deployment-diagram.png" alt="Diagrama de Implantação" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Portanto, o diagrama de implantação não é apenas uma ferramenta técnica para representação da infraestrutura; ele é fundamental para a gestão estratégica e operacional do projeto. Facilita a implementação sistemática e eficiente do aplicativo móvel, garantindo que o sistema seja robusto, escalável e seguro. Este entendimento compartilhado é vital para o sucesso do projeto, permitindo que o time de desenvolvimento entenda como funciona a comunicação entre os serviços.

## 6.4 Tecnologias e Ferramentas

&emsp;&emsp; As tecnologias e ferramentas escolhidas para o desenvolvimento do projeto LegacyLab foram selecionadas com base nos requisitos do projeto, nas necessidades dos usuários e nas melhores práticas de desenvolvimento de software. Abaixo, elas são listadas por categoria, incluindo as tecnologias de frontend, backend, ferramentas de desenvolvimento, testes e QA, e acesso a banco de dados.

### 1. GitHub

&emsp;&emsp;O GitHub é uma plataforma de hospedagem de código-fonte e colaboração para desenvolvedores de software. Ele oferece controle de versão usando o sistema Git, que permite que os desenvolvedores trabalhem em conjunto em projetos de software, registrem e controlem as alterações no código-fonte ao longo do tempo.

&emsp;&emsp;Em metodologias ágeis, como o Scrum, o GitHub desempenha um papel importante na facilitação da colaboração e na gestão do desenvolvimento de software. Algumas maneiras pelas quais o GitHub se aplica em metodologias ágeis e frameworks como o Scrum são:

1. **Controle de versão**: O GitHub fornece um controle de versão eficaz por meio do Git, permitindo que os desenvolvedores registrem e controlem as alterações no código-fonte. Isso é essencial em metodologias ágeis, onde as equipes frequentemente iteram sobre o código e precisam manter um histórico claro das mudanças.

2. **Colaboração distribuída**: O GitHub permite que equipes distribuídas geograficamente trabalhem juntas em projetos de software. Isso é particularmente útil em metodologias ágeis, onde a colaboração entre os membros da equipe é fundamental para o sucesso do projeto.

3. **Gerenciamento de problemas e tarefas**: O GitHub oferece recursos para gerenciar problemas, tarefas e melhorias no código-fonte por meio de seu sistema de problemas (issues) e projetos. Isso é útil em metodologias ágeis, onde as equipes precisam rastrear e priorizar o trabalho a ser feito em cada iteração (sprint).

4. **Revisão de código**: O GitHub fornece recursos para revisão de código por meio de solicitações de pull (*pull requests*), onde os membros da equipe podem revisar, comentar e aprovar as alterações propostas antes de serem mescladas no código principal. Isso promove a colaboração e a qualidade do código, aspectos essenciais em metodologias ágeis como o Scrum.

### 2. Desenvolvimento Frontend

&emsp;&emsp; Para o desenvolvimento do frontend do LegacyLab, foram escolhidas as seguintes tecnologias e ferramentas:

#### React Native

<div align="center">
  <sub>Figura 11: React Native</sub>
  <img src="./images/technologies/react-native.png" alt="React Native Logo" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; Para o desenvolvimento do frontend do LegacyLab, foi escolhido o framework React Native, que permite a criação de aplicativos móveis nativos para iOS e Android usando JavaScript e React. O React Native é uma escolha popular para o desenvolvimento de aplicativos móveis, pois oferece uma abordagem baseada em componentes, facilitando a criação de interfaces de usuário reativas e dinâmicas. 

&emsp;&emsp; Além disso, o React Native permite o desenvolvimento de aplicativos multiplataforma (Android e IOS), o que é essencial para garantir a acessibilidade e a usabilidade do aplicativo em diferentes dispositivos e sistemas operacionais.

<br>

#### Expo

<div align="center">
  <sub>Figura 12: Expo</sub>
  <img src="./images/technologies/expo.png" alt="Expo Logo" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; Expo é uma plataforma de código aberto para o desenvolvimento de aplicativos móveis nativos com React Native. O Expo oferece uma série de ferramentas e serviços para simplificar o desenvolvimento de aplicativos, incluindo um conjunto de APIs nativas, um ambiente de desenvolvimento integrado e uma plataforma de distribuição de aplicativos. O Expo é uma escolha popular para o desenvolvimento de aplicativos móveis com React Native devido à sua facilidade de uso, flexibilidade e suporte a recursos avançados.

&emsp;&emsp; Para o desenvolvimento, foi utilizado o expo router, que utiliza de um sistema file-based routing para facilitar a navegação entre as telas do aplicativo. Além disso, o Expo-Go foi utilizado para testar o aplicativo em tempo real em dispositivos móveis.

<br>

### 3. Desenvolvimento Backend

&emsp;&emsp; Para o desenvolvimento do backend do LegacyLab, foram escolhidas as seguintes tecnologias e ferramentas:

<div align="center">
  <sub>Figura 13: ASP.NET Core</sub>
  <img src="./images/technologies/aspnet.png" alt="ASP.NET Core Logo" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; ASP.NET Core é um framework de desenvolvimento de software de código aberto da Microsoft, amplamente utilizado para a criação de aplicativos web e serviços web. Com suporte para C#, ASP.NET Core oferece uma abordagem modular e escalável para o desenvolvimento de aplicativos, permitindo a criação de APIs RESTful. O ASP.NET Core é uma escolha popular para o desenvolvimento de aplicativos web e serviços web devido à sua escalabilidade, desempenho e segurança.

&emsp;&emsp; O uso de C# e ASP.NET Core no backend do LegacyLab permite a integração eficiente com o banco de dados PostgreSQL, a implementação de serviços RESTful para comunicação com o frontend e a criação de uma arquitetura robusta para o sistema.

<br>

### 4. Ferramentas de Desenvolvimento

&emsp;&emsp; Para o desenvolvimento do projeto LegacyLab, foram escolhidas as seguintes ferramentas de desenvolvimento:
<div align="center">
  <sub>Figura 14: SWAGGER Logo</sub>
  <img src="./images/technologies/swagger.jpg" alt="ASP.NET Core Logo" width="100%">
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; Swagger é uma ferramenta de código aberto que permite a documentação, teste e implementação de APIs RESTful. Com o Swagger, é possível gerar automaticamente a documentação da API, facilitando a compreensão e o uso dos endpoints disponíveis. Além disso, o Swagger oferece uma interface interativa para testar os endpoints da API, permitindo validar o comportamento antes da integração com o frontend.

### 5. Testes e QA
&emsp;&emsp; Para garantir a qualidade e a confiabilidade do projeto LegacyLab, foram escolhidas as seguintes tecnologias e ferramentas de testes e QA:

#### Unit

<div align="center">
  <sub>Figura 15: xUnit Logo</sub>
  <img src="./images/technologies/xunit.png" alt="xUnit Logo" width="100%">
  <sup>Fonte: Xunit.net</sup>
</div>

&emsp;&emsp; xUnit é um framework de teste unitário para várias linguagens de programação, incluindo C#. Com o xUnit, é possível escrever e executar testes unitários de forma eficiente, garantindo que o código seja testado de maneira abrangente e confiável. O xUnit é uma escolha popular para o desenvolvimento de software em C# devido à sua simplicidade, flexibilidade e suporte a práticas de teste ágeis.

<br>

#### pytest

<div align="center">
  <sub>Figura 16: pytest Logo</sub>
  <img src="./images/technologies/pytest.png" alt="pytest Logo" width="100%">
  <sup>Fonte: pythonwife.com</sup>
</div>

&emsp;&emsp; Pytest é um framework de teste para Python, amplamente utilizado para escrever e executar testes de forma eficiente. Com o Pytest, é possível realizar testes unitários, de integração e funcionais, assegurando que o código Python seja testado de maneira abrangente e confiável. Pytest é uma escolha popular entre desenvolvedores Python devido à sua simplicidade, extensibilidade e suporte a práticas de teste ágeis. Ele permite a execução de testes com pouca configuração, integração fácil com outras ferramentas e oferece uma variedade de plugins para expandir sua funcionalidade.

<br>

#### Moq

<div align="center">
  <sub>Figura 17: Moq Logo</sub>
  <img src="./images/technologies/moq.png" alt="Moq Logo" width="100%">
  <sup>Fonte: Luis Llamas</sup>
</div>

&emsp;&emsp; Moq é uma biblioteca de mocking para .NET que permite criar objetos falsos para testes unitários. Com o Moq, é possível simular o comportamento de objetos reais, facilitando a criação de testes unitários independentes e isolados. O Moq é amplamente utilizado no desenvolvimento de software em C# para testes de unidade e integração.

<br>

### 6. Acesso a Banco de Dados

&emsp;&emsp; Para o acesso ao banco de dados no projeto LegacyLab, foram escolhidas as seguintes tecnologias e ferramentas:

#### PostgreSQL

<div align="center">
  <sub>Figura 18: PostgreSQL Logo</sub>
  <img src="./images/technologies/postgres.png" alt="PostgreSQL Logo" width="100%">
  <sup>Fonte: Driven Education</sup>
</div>

&emsp;&emsp; PostgreSQL é um sistema de gerenciamento de banco de dados relacional de código aberto e de alta performance. O PostgreSQL é amplamente utilizado em aplicativos web e serviços web devido à sua confiabilidade, escalabilidade e suporte a recursos avançados, como transações ACID e indexação avançada.

<br>

#### Dapper micro ORM

<div align="center">
  <sub>Figura 19: Dapper Logo</sub>
  <img src="./images/technologies/dapper.jpeg" alt="Dapper Logo" width="100%">
  <sup>Fonte: Dapper</sup>
</div>

&emsp;&emsp; Dapper é um micro ORM (Object-Relational Mapping) para .NET que permite acesso rápido a bancos de dados relacionais usando SQL e mapeamento simples de objetos. O Dapper é uma escolha popular para o acesso a bancos de dados em aplicativos .NET devido à sua simplicidade, desempenho e eficiência.

#### ElephantSQL

<div align="center">
  <sub>Figura 20: ElephantSQL Logo</sub>
  <img src="./images/technologies/elephantsql.png" alt="ElephantSQL Logo" width="100%">
  <sup>Fonte: Elephantsql.com</sup>
</div>

&emsp;&emsp; ElephantSQL é um serviço de hospedagem de banco de dados PostgreSQL em nuvem, facilitando a implantação e o gerenciamento de bancos de dados. O ElephantSQL oferece uma infraestrutura escalável e confiável para o armazenamento de dados, garantindo a disponibilidade e a segurança das informações.


### 7. Sistema de Recomendação

&emsp;&emsp; O sistema de recomendação é uma parte essencial da solução, permitindo sugestões personalizadas de projetos para os CEOs com base em suas interações passadas e interesses. Para implementar o sistema de recomendação, foram escolhidas as seguintes tecnologias e ferramentas:

#### Pandas

<div align="center">
  <sub>Figura 21: Pandas Logo</sub>
  <img src="./images/technologies/pandas.png" alt="Pandas Logo" width="100%">
  <sup>Fonte: DataScientest</sup>
</div>

&emsp;&emsp; Pandas é uma biblioteca de análise de dados em Python que fornece estruturas de dados e ferramentas para manipulação e análise de dados. Com o Pandas, é possível realizar operações de limpeza, transformação e análise de dados de forma eficiente, facilitando a preparação dos dados para o sistema de recomendação.

&emsp;&emsp; É uma biblioteca amplamente utilizada em projetos de ciência de dados e aprendizado de máquina devido à sua flexibilidade, desempenho e suporte a operações avançadas de análise de dados.

### 8. API Externa

#### ChatGPT

<div align="center">
  <sub>Figura 22: Chat GPT Logo</sub>
  <img src="./images/technologies/gpt.png" alt="Chat GPT Logo" width="100%">
  <sup>Fonte: Agora Software</sup>
</div>

&emsp;&emsp; Para aprimorar a experiência do usuário e fornecer descrições mais atraentes dos projetos dentro da aplicação, o LegacyLab utiliza a API do ChatGPT para reescrever os textos dos usuários. O ChatGPT é um modelo de linguagem de geração de texto desenvolvido pela OpenAI que gera texto natural de alta qualidade em uma variedade de estilos e contextos. A API do ChatGPT permite integrar a capacidade de geração de texto do modelo diretamente no aplicativo, melhorando a qualidade e a relevância das descrições dos projetos apresentados aos CEOs.

### 9. Deploy em Nuvem

&emsp;&emsp; Para o deploy do projeto LegacyLab em nuvem, foram escolhidas as seguintes tecnologias e ferramentas:

#### AWS Elastic Compute Cloud (EC2)

<div align="center">
  <sub>Figura 23: AWS EC2 Logo</sub>
  <img src="./images/technologies/aws-ec2.jpg" alt="AWS EC2 Logo" width="100%">
  <sup>Fonte: AI Balsan</sup>
</div>

<br>

&emsp;&emsp; Amazon Elastic Compute Cloud (EC2) é um serviço de computação em nuvem da Amazon Web Services que oferece capacidade de computação escalável na nuvem. Com o EC2, é possível implantar e gerenciar servidores virtuais, permitindo a execução de aplicativos e serviços de forma flexível. No contexto do LegacyLab, o EC2 será utilizado para hospedar os serviços backend e o frontend do aplicativo.

<br>

#### Relational Database Service (RDS)
<div align="center">
  <sub>Figura 24: AWS RDS Logo</sub>
  <img src="./images/technologies/rds.png" alt="AWS RDS Logo" width="100%">
  <sup>Fonte: Flexa Cloud</sup>
</div>

&emsp;&emsp; Amazon Relational Database Service (RDS) é um serviço de banco de dados relacional gerenciado da Amazon Web Services que oferece implantação e operação fáceis de bancos de dados relacionais na nuvem. No contexto do LegacyLab, o RDS será utilizado para hospedar o banco de dados PostgreSQL que armazena os dados do aplicativo.

<br>

## 6.5 Padrões de Trabalho

&emsp;&emsp;Padrões de trabalho são diretrizes, práticas ou procedimentos estabelecidos para orientar a execução de tarefas, processos ou atividades dentro de uma organização, equipe ou projeto.

&emsp;&emsp;Ao estabelecer padrões de trabalho, o grupo de desenvolvedores do LegacyLab busca alcançar os seguintes objetivos:

1. **Consistência**: Garantir que as atividades sejam realizadas de maneira uniforme e padronizada em toda a organização.

2. **Eficiência**: Promover a utilização eficaz dos recursos, reduzindo o tempo e os esforços desnecessários.

3. **Qualidade**: Assegurar que os produtos ou serviços atendam aos padrões de qualidade estabelecidos e às expectativas das partes interessadas.

4. **Colaboração**: Facilitar a comunicação e a cooperação entre os membros da equipe, promovendo um ambiente de trabalho colaborativo.

5. **Melhoria Contínua**: Fornecer uma base para a análise e aprimoramento contínuo dos processos e práticas de trabalho.

&emsp;&emsp;Os padrões de trabalho do LegacyLab contemplam:

- Procedimentos para gerenciamento de projetos, como planejamento, execução e controle de atividades.
- Processos para garantia da qualidade, como testes de software, controle de versões e revisões de código.
- Normas de conduta profissional e ética, como políticas de comunicação não violenta e respeito no ambiente de trabalho.

&emsp;&emsp;Além disso, também são explorados outros conceitos técnicos de padronização:

### Padrão de Nomenclatura
---

&emsp;&emsp;Com o objetivo de padronizar nomes de variáveis, funções, classes e objetos no código do LegacyLab, foi importante seguir as seguintes convenções de nomenclatura:

### Classes
- **Nome:** Uso de substantivos que descrevem claramente o papel da classe. 
- **Formato:** PascalCase (cada palavra começa com uma letra maiúscula).

**Exemplo:**
```csharp
public class ProjectRepository : IProjectRepository
public class ProjectController : ControllerBase
```

### Interfaces
- **Nome:** Uso de substantivos ou adjetivos que descrevem a funcionalidade, precedidos por "I".
- **Formato:** PascalCase.

**Exemplo:**
```csharp
public interface IProjectRepository
public interface IOpenAIService
```

### Métodos (Funções)
- **Nome:** Uso de verbos ou verbos seguidos por substantivos que indicam claramente o que o método faz.
- **Formato:** PascalCase para métodos públicos e camelCase (primeira palavra minúscula) para métodos privados.

**Exemplo:**
```csharp
public async Task<IEnumerable<ProjectDTO>> GetRecommendedProjects(int userId)
public IActionResult GetRecommendedProjects(int userId)
```

### Variáveis e Campos
- **Nome:** Uso de nomes descritivos que explicam o propósito da variável ou campo.
- **Formato:** camelCase para variáveis e campos privados. Use underscores (_) para campos privados somente se necessário para distinguir de parâmetros de métodos.

**Exemplo:**
```csharp
private readonly IDbAccess _db;
private readonly IProjectRepository _projectRepository;
private readonly IOpenAIService _openAIService;
```

### Parâmetros de Método
- **Nome:** Uso de nomes descritivos que indicam claramente o propósito do parâmetro.
- **Formato:** camelCase.

**Exemplo:**
```csharp
public async Task<IEnumerable<ProjectDTO>> GetRecommendedProjects(int userId)
public async Task<IActionResult> GetRecommendedProjects(int userId)
```

### Padrão do Backend
---

&emsp;&emsp;O padrão de nomenclatura adotado segue as convenções de nomenclatura do C# e ASP.NET Core, onde os nomes das classes e objetos são escritos em PascalCase, as variáveis em camelCase, e as rotas dos endpoints seguem a especificação de nomes de recursos RESTful.

&emsp;&emsp;Por exemplo, no controller deprojetos, temos a classe ````ProjectController````, que segue a convenção de nomear os controladores com o sufixo "Controller". Além disso, as rotas dos endpoints são definidas utilizando o atributo ````[Route]````, onde o nome do recurso é especificado entre chaves, como em ````[HttpPost("{projectId}/synergies")]````.

```c#
public class ProjectController : ControllerBase
    {
        private readonly ISynergyRepository _synergyRepository;

        public ProjectController(ISynergyRepository synergyRepository)
        {
            _synergyRepository = synergyRepository;
        }
     (...)
    }
```

&emsp;&emsp;Os modelos (Models) são nomeados de acordo com o conceito que representam, utilizando também a convenção de PascalCase, como SynergyModel e SynergyUpdateModel. Já os DTOs são identificados com o sufixo "DTO", como SynergyBodyModel, indicando que são objetos utilizados para transferência de dados entre a API e o cliente.

&emsp;&emsp;Os repositórios (Repositories) são nomeados de forma descritiva, indicando a entidade ou o conceito que estão manipulando, como _synergyRepository.

&emsp;&emsp;O backend do LegacyLab segue os padrões de desenvolvimento da arquitetura SOA, que presa pelo desenvolvimento de features a partir de serviços.

&emsp;&emsp;O bom desenvolvimento de back-end é crucial para a construção de aplicações robustas e escaláveis, e seguir padrões de trabalho bem definidos é essencial para manter a organização e a eficiência do código. A estrutura do back-end geralmente envolve a separação lógica de diferentes camadas e responsabilidades, o que facilita a manutenção e a colaboração entre desenvolvedores.

### Estrutura de Pastas

&emsp;&emsp;O LegacyLab criou uma estrutura de pastas organizada de maneira clara, seguindo práticas recomendadas para desenvolvimento back-end:

- **Controllers**: Esta pasta contém os controladores, responsáveis por receber as requisições HTTP, processá-las e retornar as respostas apropriadas. Eles atuam como intermediários entre as requisições do cliente e a lógica de negócios da aplicação.

- **DTOs** (Data Transfer Objects): Os DTOs são usados para transferir dados entre as camadas da aplicação. Eles ajudam a encapsular os dados que serão recebidos, facilitando a validação e a transformação dos dados.

- **Models**: A pasta Models contém as definições das entidades do domínio da aplicação. Estas entidades representam os objetos do mundo real ou conceitos importantes para o funcionamento do sistema, principalmente no sentido de enviar informações.

- **Repositories**: Repositórios são responsáveis por encapsular a lógica de acesso aos dados. Eles fornecem uma interface para realizar operações de leitura e escrita no banco de dados, permitindo que a lógica de negócios se mantenha isolada dos detalhes de implementação de persistência.


### Padrão do Frontend
---

&emsp;&emsp;O desenvolvimento de um projeto com React Native e Expo é um processo que envolve a definição de padrões claros para garantir a organização e a eficiência do código. Neste contexto, é essencial adotar convenções de nomenclatura e estruturação de pastas que facilitem a colaboração e manutenção do projeto.

&emsp;&emsp;Para começar, as pastas do projeto foram nomeadas utilizando **camelCase**, o que ajuda a manter a consistência e a clareza na organização do código. Exemplos dessas pastas incluem **assets**, onde são armazenados recursos como fontes e imagens, **components**, que contém componentes reutilizáveis, **constants**, para valores constantes usados no projeto, **styles**, que guarda os arquivos de estilo, e **utils**, que abrange funções utilitárias e configurações gerais.

&emsp;&emsp;Dentro da pasta app, as telas do aplicativo, também organizadas em *camelCase*, desempenham um papel central na estrutura do projeto. Essas telas representam diferentes partes da interface do usuário e são compostas por componentes bem definidos.

&emsp;&emsp;A nomenclatura das classes e componentes segue o padrão *PascalCase*, que é amplamente utilizado na comunidade de desenvolvimento para diferenciar visualmente os componentes e classes das variáveis e funções. Por exemplo, classes e componentes como Button, InfiniteFeed e MacroCard são nomeados utilizando *PascalCase*.

&emsp;&emsp;Por outro lado, as variáveis são nomeadas utilizando *camelCase*, garantindo que a distinção entre variáveis e componentes seja clara.

### Metodologia Ágil
---

&emsp;&emsp;O grupo LegacyLab se encaixa nos padrões de trabalho da metodologia ágil, criada em resposta às necessidades dos desenvolvedores de software no início do século XXI. Ao se encaixar no contexto de desenvolvimento práticado na construção da solução, é interessante mencionar os 4 fundamentos chave da [metodologia ágil](https://agilemanifesto.org/iso/ptbr/manifesto.html), que guia boas práticas de criação e desenvolvimento de sistemas e soluções.

- Indivíduos e interações mais que processos e ferramentas;
- Software em funcionamento mais que documentação abrangente;
- Colaboração com o cliente mais que negociação de contratos;
- Responder a mudanças mais que seguir um plano.

### Metodologia SCRUM
---

&emsp;&emsp;Assim como a Metodologia Ágil, o LegacyLab utiliza o *framework* de gerenciamento SCRUM. Esse *framework* permite que as equipes se auto-organizem e trabalhem em direção a um objetivo comum. Essa estrutura descreve um conjunto de reuniões, ferramentas e funções para uma entrega eficiente de projetos, entre elas:

### Times Scrum
&emsp;&emsp;Grupos de profissionais multidisciplinares que trabalham juntos para entregar incrementos de produto de forma iterativa e incremental. Eles são auto-organizados e interdisciplinares, com papéis bem definidos, como Scrum Master e Membros do Time.

### Sprints
&emsp;&emsp;Iterações fixas de tempo (2 semanas no contexto do LegacyLab) durante as quais a equipe Scrum trabalha para entregar um incremento de produto pronto para ser lançado. As sprints são compostas por atividades planejadas, como planejamento, desenvolvimento, revisão e retrospectiva.

### Scrum Diário
&emsp;&emsp;O Scrum diário (ou *daily*) é uma reunião curta em que os membros da equipe se apresentam e planejam o dia. Eles relatam o trabalho concluído e expressam os desafios no cumprimento das metas do Sprint. A equipe se alinha, entendendo como está a entrega de cada membro, o que fizeram no dia anterior, o que planejam realizar no dia e se existe algum impedimento que possa influenciar na entrega de tarefas.

### Entrega de Sprint
&emsp;&emsp;Ao final do Sprint, a equipe se reúne para uma sessão informal para revisar o trabalho concluído e apresentá-lo às partes interessadas. O responsável pelo produto também pode retrabalhar o product backlog com base no Sprint atual.

### Retrospectiva do Sprint
&emsp;&emsp;A equipe se reúne para documentar e discutir o que funcionou e o que não funcionou durante o Sprint. As ideias geradas são usadas para melhorar Sprints futuros.


### Commits:
&emsp;&emsp;Alterações individuais feitas no código-fonte, acompanhadas de uma mensagem descritiva. Os commits são utilizados para rastrear e gerenciar as alterações no código ao longo do tempo. Eles são frequentemente associados a uma tarefa ou problema específico. O LegacyLab optou por seguir os padrões do  [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/).

````feat:```` Indica a adição de uma nova funcionalidade ao projeto.

````fix:```` Usado para correções de bugs.

```docs:``` Refere-se exclusivamente a mudanças na documentação.

```refactor:``` Utilizado quando fazemos uma alteração no código que nem corrige um bug, nem adiciona uma funcionalidade. Pense como uma refatoração, de fato. Quando refatoramos, tentamos fazer uma mesma coisa com uma qualidade superior, sem adicionar funcionalidades nem corrigir bugs (isso entra em outro tipo e escopo).

```test:``` Inclui tudo que é relacionado a testes no projeto.

Exemplo de Commit Usando Conventional Commits:

>docs(3.4): add logic model's image

### *Pull Requests*:
&emsp;&emsp;Solicitações feitas por membros da equipe para mesclar suas alterações em uma branch de desenvolvimento principal. Eles fornecem uma maneira de revisar, discutir e aprovar as alterações antes de serem mescladas no código principal. *Pull requests* também podem ser usados para iniciar discussões e colaboração entre membros da equipe.

**Título**: resume sobre o que é o pull request.
AÉRA DO PROJETO | tema do pr
exemplo: 
> BACK | user middleware

**Descrição**: Explica o que contém no pull request.
exemplo:
># :memo: Changelog
> - adds middleware structure

&emsp;&emsp;Além do corpo do pull request, o LegacyLab também padronizou revisores, *labels*, *milestones*, prazos e *issues*.

### *Labels*:
&emsp;&emsp;Marcadores ou tags atribuídos a problemas, *pull requests* ou outras atividades no GitHub para categorizá-los ou organizá-los de acordo com critérios específicos, como prioridade, tipo de tarefa, status, etc. *Labels* ajudam a manter o fluxo de trabalho organizado e a identificar rapidamente o que precisa ser feito.

&emsp;&emsp;Guiadas pelos artefatos de cada sprint, as *labels* marcam cada card do project (será explicado a seguir) e também cada pull request. 

### Issues:
&emsp;&emsp;As Issues são uma ferramenta do GitHub que permite aos usuários reportar problemas, solicitar novas funcionalidades ou discutir ideias dentro de um repositório de código. Elas definem as tarefas planejadas na *planning*.

### Project:
&emsp;&emsp;O GitHub Projects é uma ferramenta de gerenciamento de projetos integrada ao GitHub, que permite que equipes organizem e acompanhem o progresso de tarefas e problemas de forma visual. Com ele, é possível criar painéis personalizados, adicionar cartões para representar tarefas e problemas, e mover esses cartões entre colunas para refletir o fluxo de trabalho. Essa funcionalidade simplifica a gestão de projetos e promove a colaboração entre os membros da equipe. No contexto do LegacyLab, o *projects* é utilizado como um kanban.

> Obs: o LegacyLab optou pela padronização em inglês, desde commits até a estrutura de código.

### Gestão do Ciclo de Vida das Tasks
---

### Processo de Gestão de Tasks
&emsp;&emsp;No contexto de uma Sprint, o ciclo de vida das tasks é gerenciado através de um quadro de tarefas (Kanban), onde cada task é representada por um card que passa por diferentes status até sua conclusão. Abaixo descrevemos o processo e as regras de negócio adotadas pelo grupo para a gestão das tasks:

#### Status das Tasks
1. **Backlog**: Tasks que foram identificadas e priorizadas, mas ainda não foram selecionadas para uma Sprint.
2. **To Do**: Tasks que foram selecionadas para a Sprint atual e estão prontas para serem trabalhadas.
3. **Prioridade**: Tasks que foram priorizadas para serem trabalhadas imediatamente após as tarefas atuais em progresso.
4. **In Progress**: Tasks que estão atualmente sendo desenvolvidas.
5. **Review**: Tasks que foram concluídas pelo desenvolvedor e estão aguardando revisão de código.
6. **Done**: Tasks que passaram pela revisão de código e testes, e estão prontas para serem integradas.
7. **Main**: Tasks que foram totalmente concluídas e integradas na branch principal.

#### Regras de Negócio
- **Seleção de Tasks para a Sprint**: Durante o planejamento da Sprint, a equipe de desenvolvimento seleciona a divisão das tasks do backlog que serão trabalhadas na Sprint.
- **Movimentação de Tasks**: Cada membro da equipe é responsável por mover os cards no quadro de tarefas conforme o progresso. Por exemplo, ao iniciar o trabalho em uma task, o desenvolvedor move o card de "To Do" para "In Progress".
- **Revisão de Código**: Antes de uma task ser considerada concluída, o código deve passar por uma revisão. O desenvolvedor cria um Pull Request (PR) no GitHub e solicita a revisão de pelo menos um colega de equipe.
- **Conclusão**: Após a aprovação do PR, a task é movida para a branch de desenvolvimento da sprint. E no final da sprint, acontece o merge da branch "develop" para a "main".

### Uso do GitHub no Processo
---

### Pull Requests (PRs)
- **Criação de PRs**: Ao completar o desenvolvimento de uma task, o desenvolvedor cria um Pull Request (PR) no GitHub. O PR deve incluir uma descrição clara do que foi implementado e referências a issues relacionadas.
- **Revisão de PRs**: Cada PR deve ser revisado por pelo menos um outro desenvolvedor da equipe. O revisor verifica o código para garantir a qualidade, aderência aos padrões de codificação e funcionamento correto.
- **Merge de PRs**: Após a aprovação, o PR pode ser mesclado na branch principal (`main`). É recomendável que os PRs passem por uma integração contínua para verificar se não introduzem erros.

### Branching Strategy
- **Feature Branches**: Cada task deve ser desenvolvida em uma branch separada, geralmente com o nome `feature/[task-id]-[descrição-curta]`.
- **Main Branch**: A branch principal deve sempre estar em um estado estável e pronto para produção. Merges na main branch são feitos somente após a aprovação de PRs.
- **Release Branches**: Para preparar uma nova versão, pode-se criar uma branch de release a partir da main branch onde serão feitos os ajustes finais e testes antes da publicação.

### Arquitetura de Codificação

- **Processo de Desenvolvimento com TDD (Test-Driven Development)**

&emsp;&emsp;O TDD é uma abordagem de desenvolvimento onde os testes são escritos antes do código funcional. Isso ajuda a garantir que o código atenda aos requisitos desde o início e facilita a manutenção e refatoração.

**Passos para Implementação de TDD**:

1. **Escrever um Teste**:
   - Escrever um teste unitário para uma pequena parte da funcionalidade que está prestes a ser desenvolvida. O teste deve falhar inicialmente, pois a funcionalidade ainda não foi implementada.

2. **Implementar o Código**:
   - Escrever o código mínimo necessário para fazer o teste passar.

3. **Refatorar**:
   - Refatorar o código para melhorar sua estrutura e qualidade, sem alterar seu comportamento externo. Certifique-se de que todos os testes continuam passando após a refatoração.

**Exemplo de TDD no Projeto**:

1. **Escrever Teste (usando xUnit)**:
   ```csharp
   public class ProjectRepositoryTests
   {
       private readonly Mock<IDbAccess> _dbAccessMock;
       private readonly ProjectRepository _projectRepository;

       public ProjectRepositoryTests()
       {
           _dbAccessMock = new Mock<IDbAccess>();
           _projectRepository = new ProjectRepository(_dbAccessMock.Object);
       }

       [Fact]
       public async Task GetRecommendedProjectsAsync_ShouldReturnProjects_WhenUserIdIsValid()
       {
           // Arrange
           var userId = 1;
           var expectedProjects = new List<ProjectDTO> { new ProjectDTO { Id = 1, Name = "Project 1" } };
           _dbAccessMock.Setup(db => db.QueryAsync<ProjectDTO>(It.IsAny<string>(), It.IsAny<object>()))
                        .ReturnsAsync(expectedProjects);

           // Act
           var result = await _projectRepository.GetRecommendedProjectsAsync(userId);

           // Assert
           Assert.NotNull(result);
           Assert.Single(result);
           Assert.Equal(expectedProjects.First().Id, result.First().Id);
       }
   }
   ```

2. **Implementar o Código**:
   ```csharp
   public class ProjectRepository : IProjectRepository
   {
       private readonly IDbAccess _dbAccess;

       public ProjectRepository(IDbAccess dbAccess)
       {
           _dbAccess = dbAccess;
       }

       public async Task<IEnumerable<ProjectDTO>> GetRecommendedProjectsAsync(int userId)
       {
           var query = @"
               SELECT
                   p.id,
                   p.name,
                   p.short_description,
                   p.description,
                   p.status
               FROM
                   recommendation r
               JOIN
                   projects p ON r.id_project = p.id
               WHERE
                   r.user_id = @UserId;
           ";

           var projects = await _dbAccess.QueryAsync<ProjectDTO>(query, new { UserId = userId });
           return projects;
       }
   }
   ```

3. **Refatorar**:
   - Verificar se o código pode ser melhorado sem alterar a funcionalidade.
   - Garantir que todos os testes continuem passando após a refatoração.


### Exemplo de Estrutura de Diretórios com TDD

```plaintext
src/
│
├── backend/
│   ├── CoreService/
│   │   ├── Controllers/
│   │   │   ├── ProjectController.cs
│   │   │   └── UserController.cs
│   │   ├── DTOs/
│   │   │   ├── ProjectDTO.cs
│   │   │   └── UserDTO.cs
│   │   ├── Models/
│   │   │   ├── ProjectModel.cs
│   │   │   └── UserModel.cs
│   │   ├── Repositories/
│   │   │   ├── ProjectRepository.cs
│   │   │   └── UserRepository.cs
│   │   ├── Services/
│   │   │   ├── IOpenAIService.cs
│   │   │   └── OpenAIService.cs
│   ├── CoreService.Tests/
│   │   ├── ControllersTests/
│   │   │   ├── ProjectControlleTests.cs
│   │   │   └── UserControllerTests.cs
│   │   ├── RepositoriesTests/
│   │   │   ├── ProjectRepositoryTests.cs
│   │   │   └── UserRepositoryTests.cs
```

### Conclusão

&emsp;&emsp;A adoção do padrão MVC, combinada com a abordagem TDD, ajuda a manter a aplicação organizada, modular e testável. A estrutura de diretórios deve refletir a separação de responsabilidades e facilitar a manutenção e evolução da aplicação. Seguindo essas diretrizes, sua equipe pode desenvolver um sistema robusto e escalável.

&emsp;&emsp;Todas essas padroniações foram importantes para o bom desenvolvimento em grupo do LegacyLab. Elas permitiram o acompanhamento de cada membro em relação ás suas entregas e ao andamento do projeto em geral.


# 7. Interface

&emsp;&emsp;Nesta seção, exploraremos os aspectos visuais e interativos da solução, focando na criação de uma interface de usuário eficiente, intuitiva e acessível. O objetivo é garantir que o aplicativo proporcione uma experiência agradável e produtiva para todos os usuários, facilitando a navegação e o uso das funcionalidades oferecidas. A seguir, detalharemos os componentes chave da interface, desde os primeiros esboços até a implementação final.

## 7.1 Projeto de Interface (Wireframes)

&emsp;&emsp;Nesta seção, são apresentados os [wireframes](https://www.figma.com/file/bhql0DXaQY5mlIhTFx637R/Legacy-Lab?type=design&node-id=105%3A1127&mode=design&t=6F0qMyvF1Mq15QtA-1) que delineiam a solução proposta para o gerenciamento das atividades realizadas pelos CEOs parceiros da Fundação Dom Cabral. Os wireframes, esboços visuais que representam a estrutura e o layout da interface da aplicação, fornecem uma visão preliminar de como os elementos serão organizados e interconectados. Essa etapa é crucial para a compreensão da arquitetura da solução e para a validação do design antes da implementação.

&emsp;&emsp;Os wireframes aqui apresentados foram desenvolvidos com base nos requisitos levantados e nas necessidades identificadas durante a fase de análise do projeto. Eles visam proporcionar uma experiência intuitiva e eficiente para os usuários finais, permitindo a visualização e a interação com as funcionalidades essenciais da aplicação. Além disso, os wireframes servem como um guia para o desenvolvimento do frontend, ajudando a garantir a consistência e a usabilidade em todo o sistema.

&emsp;&emsp;Os wireframes apresentados nesta seção foram desenvolvidos seguindo a abordagem "mobile first", o que é especialmente relevante em uma aplicação que promove a conexão de projetos de diferentes CEOs. Ao priorizar a experiência do usuário em dispositivos móveis, a aplicação se torna acessível em diversos contextos, permitindo que os CEOs parceiros interajam com seus projetos de forma intuitiva e eficiente, independentemente do dispositivo que estejam utilizando. Essa adaptação para dispositivos móveis não apenas amplia o alcance da aplicação, mas também reflete a necessidade de mobilidade e flexibilidade em um ambiente empresarial dinâmico, onde os CEOs podem precisar acessar e colaborar em projetos enquanto estão em movimento. Dessa forma, a abordagem "mobile first" não apenas otimiza a usabilidade da aplicação, mas também contribui para a sua missão de facilitar a conexão e a colaboração entre os CEOs parceiros da Fundação Dom Cabral.

### *Home Page*

&emsp;&emsp;Está é a primeira tela na qual o usuário entra em contato com o sistema do LegacyLab. Nela são apresentados as indicações do sistema em relação á notificações (caso algum CEO demonstre interesse ou marque uma sinergia com algum projeto do usuário atuante). Além disso são apresentados *cards* (escolhidos por conta da usabilidade em ambientes mmobile), que proporcionam ao usuário um rápido entenimento sobre o projeto em questão.

<div align="center">
  <sub>Figura 25: Home page LegacyLab</sub><br>
  <img src="/docs/images/wireframe/Home.png" alt="home page" width="40%"><br><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Conforme a imagem, as informações do projeto nesse contexto da *home page* contém:

- Nome;
- Empresa responsáveleto;
- CEO responsável;
- Etiqueta com o macrotema;
- Microtema;
- Breve descrição de até 400 caractéres.

&emsp;&emsp;Além das informações essenciais, existe a opção de demonstrar interesse em um projeto. Essa funcionalidade é realizada através de um botão presente no *header* do *card* do projeto. Ação que contribui para o sistema de recomendação existente nesta mesma página, que sera explicado á seguir.

&emsp;&emsp;A escolha do ícone de estrela se justifica com base nas heurísticas de Nielsen para o design de interface, principalmente em relação ao reconhecimento em vez de memorização, uma vez que o ícone de estrela proporciona ao cérebro humano a ideia que deseja-se passar ao se interessar por um projeto.

&emsp;&emsp;É na *home* onde os *cards* recomendados aparecem. Ou seja, o sistema de recomendação da plataforma LegacyLab, identifica quais são os prováveis projetos que o usuário mais teria interesse em consumir seu conteúdo.

&emsp;&emsp;Por fim, existe também na *home* como em todas as outras páginas da aplicação, um menu de navegação. Esse elemento possibilita uma fácil navegação pela aplicação, contribuindo com o requisito não funcional de usabilidade da solução. 


### *Search Page*

&emsp;&emsp;Na página representada na figura abaixo, o usuário tem a liberdade de escolher e dinamizar a busca por macrotema de projetos. Mais uma vez, o fromato de escolha para os itens clicáveis se encaixam no contexto *mobile first* da aplicação e garantem boa usabilidade para o usuário.

<div align="center">
  <sub>Figura 26: Search Page LegacyLab</sub><br>
  <img src="/docs/images/wireframe/Search.png" alt="Search page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Ainda sim, o *header* e o menu de navegação se fazem presentes, bem como uma barra de pesquisa que garante a otimização de busca por algm projeto específico.

### *Macrotheme Page*

<div align="center">
  <sub>Figura 27: Macrotheme Page LegacyLab</sub><br>
  <img src="/docs/images/wireframe/Macrotheme.png" alt="Macrotheme page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Ao esolher um dos macrotemas disponíveis na página de busca, o usuário tem acesso aos projetos do tema identificado. Nessa mesma página, a busca por outros temas aparece em baixo do *header* da aplicação, garantindo o menor número de camadas da informação e melhorando a experiência do usuário.

### *Profile Page*

<div align="center">
  <sub>Figura 28: Profile Page LegacyLab</sub><br>
  <img src="/docs/images/wireframe/Profile.png" alt="Profile page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;A página de perfil do usuário permite a publucação de novos projetos e a edição de projetos ativos. Nesse contexto, os ícones e botões foram pensados para expressar de forma direta a funcionalidade de cada um deles, proporcionando ao atuador de ações uma maior liberdade dentro do LegacyLab.

&emsp;&emsp;Uma técnica avançada de design para mobile utilizada no desenvolvimento da solução foi a antecipação de ação do usuário. Isso envolve prever as necessidades do usuário e oferecer opções relevantes de forma proativa. Por exemplo, ao detectar que um CEO parceiro está revisando um projeto específico, a aplicação antecipa sua próxima ação e sugere caminhos com base nesse contexto. Isso não apenas economiza tempo para o usuário, mas também aumenta a eficiência e a fluidez da experiência.

### *Project Page*

<div align="center">
  <sub>Figura 29: Project Page LegacyLab</sub><br>
  <img src="/docs/images/wireframe/Project.png" alt="Project page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Na página do projeto, as mesmas informações disponíveis no *card* voltam a aparecer, junto com uma descrição mais profunda sobre o mesmo. Ademais, é nessa página da solução onde o usuário encontra informações sobre quais as sinergias atuantes e a lista de interessados (usuários que sinalizaram pressionando o botão com o ícone de estrela). 

&emsp;&emsp;É importante mencionar que tanto a lista de sinergias quanto os interessados no projeto, são disponibilizados por elementos chamados "sanfonas" no campo de UX e UI design. Esse tipo de elemento além de ser adequado para o uso de aplicações *mobile*, garantem que a informação seja passada com precisão e conforte o usuário final.

<div align="center">
  <sub>Figura 30: Demonstração da Sanfona</sub><br>
  <img src="/docs/images/wireframe/Project-Accordion.png" alt="Project-Accordion page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Outra funcionalidade relevante, é a opção de marcar a sinergia de projeto. O grupo de desenvolvedores do LegacyLab optou por localizar essa ação do sistema nessa camada e nível de informação por ela representar uma conexão densa entre diferentes projetos e do usuário precisar passar por uma base maior de informações para marcar a sinergia.

### Cadastro de Sinergia

&emsp;&emsp;Ao cadastrar uma sinergia, o usuário precisará escolher um projeto seu cadastrado no LegacyLab. Bem como o nível de sinergia preferível.

<div align="center">
  <sub>Figura 31: Cadastro de Sinergia</sub><br>
  <img src="/docs/images/wireframe/Synergy-register.png" alt="Synergy-register page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Embora nesta etapa ainda não tenham ocorrido testes de usabilidade formais, o processo de construção do wireframe foi orientado pela premissa de antecipar as necessidades do usuário e proporcionar uma experiência intuitiva. Para isso, foram consideradas boas práticas de design mobile, como a disposição de elementos de forma hierárquica e a priorização de funcionalidades de acordo com sua relevância para o usuário. À medida que os testes de usabilidade forem realizados no futuro, o feedback dos usuários será fundamental para refinar e aprimorar ainda mais o design do wireframe, garantindo que atenda plenamente às expectativas e necessidades dos CEOs parceiros da Fundação Dom Cabral.

### Histórico de Sinergia

&emsp;&emsp;Uma das principais funcionalidades que atente á demanda da Fundação Dom Cabral é a visualização de ações realisadas em cada sinergia.

<div align="center">
  <sub>Figura 32: Histórico de Sinergia</sub><br>
  <img src="/docs/images/wireframe/Synergy.png" alt="Synergy page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Essa página pode ser acessada a partir da escolha de uma sinergia disponível na sanfona da página do projeto. Essa pontual e importante funcionalidade permite o registro de atividades ocorridas ao longo do tempo, contribuindo para o principal objetivo da FDC e do CEO´s Legacy, o legado de ações registradas.

### Cadastro de Projeto

&emsp;&emsp;Ao cadastrar uma projeto, funcionalidade disponível na página de perfil, o usuário precisará indicar as informações requeridas pelo sistema.

<div align="center">
  <sub>Figura 33: Cadastro de Projeto</sub><br>
  <img src="/docs/images/wireframe/Registration-project.png" alt="SRegistration-project page" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;A escolha de sanfonas nesta etapa da aplicação confere agilidade e garantem a padronização de macro e microtemas do sistema. Seguindo cordialmente a herística de consistência e padronização definida por Nielsen.

&emsp;&emsp;Os wireframes apresentados nesta seção constituem uma etapa crucial no desenvolvimento da solução para o gerenciamento das atividades dos CEOs parceiros da Fundação Dom Cabral. Ao seguir uma abordagem "mobile first", a equipe demonstra uma preocupação fundamental com a acessibilidade e a usabilidade em diferentes contextos empresariais. Esses esboços visuais não apenas delineiam a estrutura e o layout da interface da aplicação, mas também proporcionam uma visão preliminar da arquitetura da solução, permitindo a validação do design antes da implementação. Ao priorizar a experiência do usuário e garantir a consistência e a eficiência em toda a aplicação, os wireframes são essenciais para assegurar a entrega de um produto final que atenda às necessidades e expectativas dos CEOs parceiros.

&emsp;&emsp;Por fim, vale ressaltar que a equipe desenvolvedora utilizou da ferramenta [Figma](https://www.figma.com/file/bhql0DXaQY5mlIhTFx637R/Legacy-Lab?type=design&node-id=105%3A1127&mode=design&t=6F0qMyvF1Mq15QtA-1) para realizar os wireframes disponíveis nesta seção. Sempre prezando pela boa utilização da ferramenta, otimizando o trabalho de futuros designers e aplicando práticas inteligêntes de UI e UX design.

## 7.2 Mockup

&emsp;&emsp;O mockup, como uma representação visual avançada da interface do usuário, evolui dos wireframes iniciais para mostrar os elementos de design detalhados, incluindo cores, tipografias e outros elementos gráficos. Essa fase é crucial para visualizar como a interface se comportará em situações reais de uso, transformando conceitos básicos em um protótipo visual próximo do produto final.

&emsp;&emsp;O mockup é uma evolução crítica dos wireframes iniciais, apresentando uma representação visual mais detalhada e refinada da interface do usuário. Esta etapa transforma conceitos básicos em um design concreto, incluindo escolhas de cores, tipografias e outros elementos gráficos, que são essenciais para visualizar como a aplicação funcionará na prática. Esta representação avançada permite que desenvolvedores, designers e stakeholders obtenham uma visão clara do produto final antes mesmo da implementação, garantindo que todos os aspectos do design se alinhem com as expectativas e requisitos do projeto.

&emsp;&emsp;Durante a transição do wireframe para o mockup e após feedbacks recebidos na validação com o parceiro, algumas alterações importantes foram implementadas para melhor atender às necessidades do projeto e dos usuários finais. Estas mudanças foram cuidadosamente selecionadas para melhorar a usabilidade e a estética da aplicação, além de alinhar a interface com as mudanças técnicas e estratégicas do projeto:

- Adição de tela de login: 

&emsp;&emsp;Uma tela de login foi adicionada ao mockup, apesar de não ter sido detalhada no wireframe original. Esta inclusão foi necessária para mapear o fluxo de autenticação dos usuários, essencial para o acesso seguro e personalizado ao sistema.

- Refinamento dos formulários de cadastro:

&emsp;&emsp;As telas contendo formulários de cadastro foram subdivididas em etapas ou páginas adicionais, para facilitar a interação do usuário e melhorar a experiência de preenchimento em dispositivos móveis.

- Adição de splash screen:

&emsp;&emsp;Implementamos uma splash screen para melhorar a experiência de inicialização do aplicativo, proporcionando uma transição visual agradável e reforçando a identidade visual da marca.

- Nova versão de card de projeto resumido:

&emsp;&emsp;Criamos uma versão reduzida do card de projeto para uso em telas onde o espaço é limitado, removendo elementos como a descrição longa para otimizar a visualização em certos cenários.

- Mudança na interatividade de interesse:

&emsp;&emsp;A funcionalidade de demonstrar interesse foi alterada para uma avaliação numérica de 1 a 5, refletindo as necessidades técnicas de realimentação do modelo de recomendação e proporcionando uma métrica mais precisa para o interesse do usuário.

&emsp;&emsp;Implementado com uma abordagem "Mobile First", o mockup foca primordialmente na otimização para dispositivos móveis, garantindo que a experiência do usuário seja priorizada em plataformas que os CEOs usam com frequência. Essa abordagem é vital em um ambiente empresarial dinâmico, onde a acessibilidade e a eficiência de uso em dispositivos móveis podem significativamente impactar a produtividade e a satisfação do usuário. Além disso, o mockup é completamente navegável, permitindo a interação e simulação das ações do usuário, o que é crucial para testar a fluidez e a intuitividade da navegação.

&emsp;&emsp;O processo de desenvolvimento do mockup levou em consideração também  a adaptação do design aos padrões e à identidade visual do parceiro, assegurando uma representação fiel do que será a versão final do aplicativo. Os elementos visuais foram cuidadosamente selecionados e padronizados para manter uma estética agradável e coerente, reforçando a marca e a identidade visual do parceiro enquanto proporcionam uma interface amigável e fácil de usar.

> Para uma exploração mais detalhada do design e interatividade propostos, acesse o mockup através do <a href="https://www.figma.com/proto/bhql0DXaQY5mlIhTFx637R/Legacy-Lab?page-id=17%3A496&node-id=394-4551&viewport=100%2C1182%2C0.62&t=W0UvUxFBgAiMMKAt-1&scaling=scale-down&starting-point-node-id=394%3A4551&show-proto-sidebar=1">link no Figma</a>.

&emsp;&emsp;É possível também visualizar as telas do mockup nas imagens abaixo:

### *Splash Screen*

&emsp;&emsp;A tela de splash screen é a primeira tela que o usuário vê ao iniciar o aplicativo. Ela fornece uma transição visual agradável e reforça a identidade visual da marca, criando uma experiência de inicialização suave e profissional.

<div align="center">
  <sub>Figura 34: Splash Screen</sub><br>
  <img src="./images/mockup/Splash-screen.png" alt="Splash Screen" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Tela de Login

&emsp;&emsp;A tela de login é essencial para garantir o acesso seguro e personalizado ao sistema. Nela, o usuário pode inserir suas credenciais para autenticação e acesso ao aplicativo ou se conectar atráves do Google.

<div align="center">
  <sub>Figura 35: Tela de Login</sub><br>
  <img src="./images/mockup/Login.png" alt="Login Screen" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Menu Inicial

&emsp;&emsp;A tela inicial do aplicativo, onde os CEOs podem navegar pelos projetos recomendados.

<div align="center">
  <sub>Figura 36: Home Page</sub><br>
  <img src="./images/mockup/Home.png" alt="Menu Inicial" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Página do Projeto

&emsp;&emsp;A tela de detalhes do projeto, onde os CEOs podem visualizar informações detalhadas, avaliar o projeto, visualizar e cadastrar sinergias.

<div align="center">
  <sub>Figura 37: Página do Projeto</sub><br>
  <img src="./images/mockup/Project.png" alt="Página de Projeto" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Menu de Pesquisa

&emsp;&emsp;A tela de pesquisa, onde os CEOs podem buscar projetos por macrotema ou pela barra de pesquisa.

<div align="center">
  <sub>Figura 38: Menu de Pesquisa</sub><br>
  <img src="./images/mockup/Search.png" alt="Menu de Pesquisa" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Projetos por Macrotema

&emsp;&emsp;A tela de projetos por macrotema, onde os CEOs podem visualizar projetos relacionados a um tema específico.

<div align="center">
  <sub>Figura 39: Projetos por Macrotema</sub><br>
  <img src="./images/mockup/Macrotheme.png" alt="Projetos por Macrotema" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Perfil do Usuário

&emsp;&emsp;A tela de perfil do usuário, onde os CEOs podem visualizar e editar suas informações pessoais e publicar novos projetos.

<div align="center">
  <sub>Figura 40: Perfil do Usuário</sub><br>
  <img src="./images/mockup/Profile.png" alt="Perfil do Usuário" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Cadastro de Projeto

&emsp;&emsp;A tela inicial de cadastro de projeto, onde os CEOs podem inserir informações sobre um novo projeto.

<div align="center">
  <sub>Figura 41: Cadastro de Projeto</sub><br>
  <img src="./images/mockup/Project-register.png" alt="Cadastro de Projeto - 1" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;A tela da segunda etapa de cadastro de projeto, onde os CEOs podem inserir informações adicionais sobre um novo projeto.

<div align="center">
  <sub>Figura 42: Cadastro de Projeto (2ª Etapa)</sub><br>
  <img src="./images/mockup/Project-register-2.png" alt="Cadastro de Projeto - 2" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Cadastro de Sinergia

&emsp;&emsp;A tela de cadastro de sinergia, onde os CEOs podem escolher o projeto pessoal que deseja relacionar com outro projeto.

<div align="center">
  <sub>Figura 43: Cadastro de Sinergia</sub><br>
  <img src="./images/mockup/Synergy-register.png" alt="Cadastro de Sinergia - 1" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;A segunda etapa de cadastro de sinergia, onde os CEOs podem definir o tipo de sinergia e adicionar informações adicionais.

<div align="center">
  <sub>Figura 44: Cadastro de Sinergia (2ª Etapa)</sub><br>
  <img src="./images/mockup/Synergy-type.png" alt="Cadastro de Sinergia - 2" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Cadastro de Atualização de Sinergia

&emsp;&emsp;A tela de cadastro de atualização de sinergia, onde os CEOs podem adicionar informações sobre a evolução da sinergia.

<div align="center">
  <sub>Figura 45: Cadastro de Atualização de Sinergia</sub><br>
  <img src="./images/mockup/Synergy-update.png" alt="Cadastro de Atualização de Sinergia" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Tela de Sinergia

&emsp;&emsp;A tela de sinergia, onde os CEOs podem visualizar informações detalhadas sobre a sinergia e as atualizações relacionadas.

<div align="center">
  <sub>Figura 46: Tela de Sinergia</sub><br>
  <img src="./images/mockup/Synergy.png" alt="Tela de Sinergia" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Popup de Notificações

&emsp;&emsp;O popup de notificações, onde os CEOs podem visualizar notificações importantes.

<div align="center">
  <sub>Figura 47: Popup de Notificações</sub><br>
  <img src="./images/mockup/Notifications.jpg" alt="Popup de Notificações" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;O desenvolvimento do mockup é uma fase importante no ciclo de vida do desenvolvimento do software, pois não apenas valida a interface do usuário antes da codificação, mas também assegura que a solução final atenderá tanto aos critérios funcionais quanto estéticos do projeto. É uma ferramenta vital para o ajuste fino da experiência do usuário, identificação e resolução de problemas de usabilidade antes que eles se tornem onerosos para resolver mais tarde no desenvolvimento. Ao finalizar esta etapa, a equipe está bem equipada para avançar para a fase de implementação com confiança, sabendo que o produto não apenas funcionará como previsto, mas também será acolhido positivamente pelos seus usuários finais.

## 7.3 Frontend
&emsp;&emsp;Esta seção detalha o processo de desenvolvimento e implementação do frontend do aplicativo Legacy Lab. O objetivo principal do frontend é proporcionar uma interface de usuário intuitiva, funcional e visualmente agradável que facilite a gestão de sinergias entre os projetos das empresas participantes do CEO's Legacy. A seguir, são apresentados em detalhes os aspectos técnicos e metodológicos do desenvolvimento, incluindo a análise de usabilidade e descrição das etapas de desenvolvimento.

### 7.3.1 Análise de Usabilidade e Implantação do Frontend
--- 

&emsp;&emsp;A implementação do frontend do Legacy Lab foi realizada com base nos mockups fornecidos, garantindo que todos os elementos de UX definidos nos wireframes e mockups fossem fielmente representados na versão final do produto. O foco principal foi criar uma interface intuitiva, funcional e visualmente agradável, seguindo as diretrizes da identidade visual fornecida pela Fundação Dom Cabral. O design do aplicativo foi desenvolvido para manter uma consistência visual em todas as telas, utilizando a paleta de cores, tipografia e estilo de ícones definidos nos mockups. A navegação foi estruturada de maneira clara e intuitiva, proporcionando uma experiência de usuário coesa e agradável.

### Desenvolvimento
&emsp;&emsp;Para construir a interface do aplicativo, dividimos o desenvolvimento em duas partes principais: a componentização e a elaboração de telas. Essa abordagem permitiu um desenvolvimento mais organizado e modular, facilitando a manutenção e futuras expansões do aplicativo.

&emsp;&emsp;**Componentização:** A componentização visa criar componentes reutilizáveis e independentes que podem ser utilizados em várias partes do aplicativo, garantindo consistência e eficiência no desenvolvimento. Elementos que se repetem em várias telas foram componentizados, como os *cards*, *headers*, *footers*, barra de pesquisa, botões, entre outros. Essa prática não só assegura a uniformidade visual e funcional, mas também facilita a atualização e manutenção do código.

&emsp;&emsp;**Elaboração de Telas:** A elaboração de telas consiste em combinar os componentes desenvolvidos para criar as diferentes interfaces do aplicativo, garantindo uma boa estrutura e que todos os elementos sejam implementados corretamente. Esta etapa envolve a integração dos componentes prontos com a adição de partes exclusivas para cada tela específica. O Legacy Lab conta com 10 páginas ao todo, cada uma projetada para oferecer intuitividade e eficiência, sendo elas:

**1. Login:** Tela inicial onde o usuário realiza o login no aplicativo.

**2. Home:** Tela principal que apresenta projetos recomendados.

**3. Projeto:** Tela que apresenta detalhes completos de um projeto específico.

**4. Cadastro de Sinergia:** Tela onde o usuário seleciona um de seus projetos para formar a sinergia.

**5. Histórico de Sinergia:** Tela que apresenta o histórico da sinergias formada, incluindo marcos de reuniões e atualizações.

**6. Atualização de Sinergia:** Tela para adicinar marcos relevantes e outros acontecimentos relacionados a parceria.

**7. Pesquisa:** Tela que permite ao usuário buscar projetos por macrotemas específicos.

**8. Feed Filtrado:** Tela que exibe projetos filtrados por um macrotema específico.

**9. Perfil:** Tela que exibe as informações do perfil do CEO e os projetos cadastrados por ele.

**10. Cadastro de Projeto:** Tela onde o usuário pode cadastrar um novo projeto.

### Desafios e Mudanças

&emsp;&emsp;Ao desenvolver uma aplicação móvel, um dos principais desafios foi garantir que todos os componentes e telas fossem responsivos e funcionassem bem em diferentes dispositivos, devido à grande variedade de dimensões de tela existente. A responsividade exigiu testagens constantes ao longo do desenvolvimento para assegurar que a aplicação se adaptasse bem a qualquer celular, proporcionando uma experiência consistente e agradável independentemente do dispositivo utilizado.

&emsp;&emsp;A estrutura de navegação foi cuidadosamente planejada para ser intuitiva e coesa. Com base nos [testes de usabilidade](#101-testes-de-usabilidade-para-mockup) realizados, ajustes foram feitos com base nos resultados e feedbacks dos usuários para garantir uma experiência fluida na navegação. Esses feedbacks resultaram em várias melhorias e ajustes na interface, ajudando a alinhar a experiência do usuário com as necessidades e expectativas dos usuários finais. Um desses ajustes por exemplo foi a fixação da barra de pesquisa, que antes desapareceria com a rolagem da página, mas ao estudar a questão de otimização, fez sentido a deixar fixa.

&emsp;&emsp;A abordagem de dividir o desenvolvimento em componentização e elaboração de telas foi essencial para criar um aplicativo modular e escalável. Essa metodologia permitiu a equipe de desenvolvimento implementar uma interface que atende aos requisitos do projeto e proporciona uma experiência de uso agradável e eficiente para os CEOs e suas equipes. A modularidade obtida facilita futuras expansões e manutenções, assegurando que o aplicativo possa evoluir conforme as necessidades dos usuários e do negócio.

### 7.3.2 Utilização do Design System
---

&emsp;&emsp; Design system é um conjunto de regras, padrões e componentes que guiam o desenvolvimento de interfaces de usuário consistentes e eficientes. Para garantir a consistência visual e funcional do aplicativo, foi desenvolvido um design system que padroniza a aparência e o comportamento dos elementos de interface

&emsp;&emsp;Por objetivos de aprendizado e prática, o design system foi criado manualmente, com referência ao [Material 3 Design Kit](https://www.figma.com/community/file/1035203688168086460), às diretrizes de design da Fundação Dom Cabral e utilizando como template para preenchimento o [Design System Template by Pixelmatters](https://www.figma.com/community/file/1035203688168086460).

&emsp;&emsp; Material 3 Design Kit é um conjunto de componentes de design prontos para uso, baseado no Material Design, que facilita a criação de interfaces consistentes e atraentes. Pixelmatters é uma agência de design que disponibiliza templates e recursos para ajudar na criação de design systems. A combinação desses recursos permitiu a criação de um design system eficiente e que supria as necessidades do projeto, garantindo a uniformidade visual e funcional do LegacyLab.

#### Cores

&emsp;&emsp;As cores utilizadas no design system foram escolhidas com base na paleta de cores da Fundação Dom Cabral, garantindo a consistência visual com a identidade da marca.

<div align="center">
  <sub>Figura 48: Paleta de cores LegacyLab</sub><br>
  <img src="./images/design_system/Colours.png" alt="Paleta de cores LegacyLab" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; As cores predominantes, analisadas durante o estudo de design da Fundação Dom Cabral e do CEO's Legacy, são o vermelho, o amarelo e o verde. Levando isso em consideração e a estética monocromática que o LegacyLab deseja seguir, as cores escolhidas para o sistema de design foram o verde, tons neutros e o branco. Além disso, para cores mais específicas, como de avaliação e tons necessários para transmitir respostas do sistema, foram adicionadas à paleta as cores amarelo, vermelho e outro tom de verde para indicar sucesso.

&emsp;&emsp; Segundo a psicologia das cores e arquétipos de marca, a escolha de um subtom de verde voltado para turquesa/ciano foi feita para transmitir confiança, segurança e inovação. Além disso, o verde é frequentemente utilizado em marcas relacionadas à sustentabilidade, saúde e bem-estar, reforçando a mensagem de inovação e impacto social positivo do LegacyLab.

&emsp;&emsp; O arquétipo de marca escolhido para o LegacyLab é o "Criador", que busca constantemente novas soluções e abordagens para os desafios, refletindo a missão de promover a inovação que a Fundação Dom Cabral almeja com a solução. Esse arquétipo também está relacionado à autenticidade e representa a vontade de se expressar de forma única, explorando novas ideias e possibilidades que rompem padrões e regras.

<div align="center">
  <sub>Figura 49: Arquétipos de Marca</sub><br>
  <img src="./images/design_system/archetypes.png" alt="Arquétipos de Marca" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; Para a criação dos shades de cada cor, foi utilizado o formato HSL (Hue, Saturation, Lightness), que permite ajustar a luminosidade e a saturação das cores de forma mais precisa. Com isso, cada tom escolhido teve sua luminosidade ajustada de 10 em 10, garantindo uma variação suave e uma ampla gama de tons para serem utilizados no design do aplicativo. Cada cor recebeu um nome específico, como "Green 100", "Green 200", "Green 300", etc., para facilitar a identificação dos tons no design das telas e aplicação dentro do sistema com um arquivo de constantes de cores.

<div align="center">
  <sub>Figura 50: Constante de definição de cores</sub><br>
  <img src="./images/design_system/colors-constant.png" alt="Constante de definição de cores" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### Tipografia

&emsp;&emsp; A tipografia utilizada no design system foi escolhida com base na legibilidade e na estética limpa e moderna que o LegacyLab deseja transmitir. A fonte escolhida foi a "Poppins", uma fonte sans-serif moderna e versátil que oferece uma excelente legibilidade em telas digitais. 

<div align="center">
  <sub>Figura 51: Tipografia LegacyLab</sub><br>
  <img src="./images/design_system/Typography.png" alt="Tipografia LegacyLab" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; Por não haver grandes necessidades de muitas variações de títulos e subtítulos, a equipe testou diferentes pesos e tamanhos para criar hierarquias visuais finalizando em 3 tipos de títulos e 2 variações de texto corrido, sendo estas:

- `Heading 1`: Poppins Bold 24pt
- `Heading 2`: Poppins  Semibold 20pt
- `Heading 3`: Poppins Medium 18pt

- `Body 1 (Semibold)`: Poppins SemiBold 14pt
- `Body 1 (Regular)`: Poppins Regular 14pt

&emsp;&emsp; Dentro do sistema, isso é aplicado de forma consistente, garantindo que os títulos e textos tenham a mesma aparência em todas as telas do aplicativo. Como exemplo, é possível analisar a aplicação dos tipos dentro de um card de projeto.

<div align="center">
  <sub>Figura 52: Exemplo de aplicação de tipografia</sub><br>
  <img src="./images/design_system/card.png" alt="Exemplo de aplicação de tipografia" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### Ícones

&emsp;&emsp; Os ícones utilizados no design system foram escolhidos com base na clareza, simplicidade e consistência visual. A biblioteca de ícones `react-native-vector-icons` foi utilizada como base, fornecendo uma ampla variedade de ícones prontos de diversos design systems para uso. Como padrão, a equipe optou por utilizar ícones do Material Icons, que são amplamente reconhecidos e utilizados em aplicativos móveis.

<div align="center">
  <sub>Figura 53: Ícones LegacyLab</sub><br>
  <img src="./images/design_system/Icons.png" alt="Ícones LegacyLab" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; Para a padronização de tamanhos, foi definido um tamanho base de 24pt para os ícones, que foi utilizado como referência para os demais tamanhos. Após a finalização do Design System, estvam dispostos em 5 tamanhos diferentes, variando de 12pt (Extra Small) a 48pt (Extra Large), para atender às necessidades de diferentes elementos da interface.

&emsp;&emsp; A equipe optou por manter a simplicidade e a clareza visual dos ícones, garantindo que fossem facilmente reconhecíveis e compreensíveis pelos usuários. A consistência visual dos ícones foi mantida em todo o aplicativo, garantindo uma experiência de usuário coesa e intuitiva.

<div align="center">
  <sub>Figura 54: Aplicação dos ícones</sub><br>
  <img src="./images/design_system/Icons-example.png" alt="Aplicação de Ícones LegacyLab" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp; O Design System foi essencial para garantir a consistência visual e funcional do aplicativo, proporcionando uma experiência de usuário coesa e intuitiva. A padronização de cores, tipografia e ícones permitiu que a equipe de desenvolvimento criasse uma interface de usuário eficiente e atraente, alinhada com as diretrizes de design da Fundação Dom Cabral e com as expectativas dos usuários finais, visto a taxa de satisfação com a interface do sistema durante os testes de usabilidade. A utilização do Design System também facilitou o desenvolvimento e a manutenção do aplicativo, garantindo que todos os elementos da interface fossem implementados de forma consistente.

### 7.3.3 Análise de Heurísticas de Nielsen
---

&emsp;&emsp;As 10 heurísticas de usabilidade de Jakob Nielsen são princípios gerais usados para avaliar a interface com o objetivo de melhorar a usabilidade de sistemas. Essas heurísticas são amplamente utilizadas para identificar problemas de usabilidade e sugerir melhorias em sistemas interativos. No LegacyLab, essas heurísticas são aplicadas para assegurar que o aplicativo seja intuitivo, eficiente e agradável para os usuários. A seguir, são apresentadas as heurísticas com exemplos relevantes extraídos das telas do aplicativo.

#### 1. Visibilidade do status do sistema
&emsp;&emsp;É um indicativo de onde o usuário está, de onde veio e para onde seguir, mantendo-os informados sobre o que está acontecendo, fornecendo feedback apropriado de forma rápida.

> Indicadores de Carregamento e Processamento: quando um usuário realiza uma ação que leva algum tempo para ser processada, como ao criar uma sinergia ou ao cadastrar um projeto, o sistema deve fornecer feedback imediato para indicar que a ação está em andamento. 

<div align="center">
  <sub>Figura 55: carregamento</sub><br>
  <img src="./images/system/loading-icon.png" alt="carregamento da tela" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 2. Compatibilidade entre o sistema e o mundo real

&emsp;&emsp;O sistema deve falar a língua dos usuários, com palavras, frases e conceitos familiares à ele, em vez de termos orientados ao sistema, ou seja, os elementos e atributos presentes na interface devem lembrar coisas que vemos no dia a dia.

> Na interface do LegacyLab, os ícones utilizados são um excelente exemplo de compatibilidade entre o sistema e o mundo real. Esses ícones são escolhidos para representar funcionalidades de maneira intuitiva e familiar para os usuários. Esses ícones ajudam os usuários a compreender rapidamente a funcionalidade de cada botão, reduzindo a curva de aprendizado e aumentando a eficiência no uso do aplicativo.

<div align="center">
  <sub>Figura 56: Ícones</sub><br>
  <img src="./images/system/footer.png" alt="ícones" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 3. Controle e liberdade do usuário

&emsp;&emsp;A interface deve ser flexível às ações do usuário, pensando que muitas vezes escolhem funções do sistema por engano e precisarão de uma "saída de emergência" claramente marcada para deixar o estado indesejado sem ter que passar por um diálogo extenso.

> Na tela de "Cadastro de Projeto" por exemplo, existem botões de navegação que permitem ao usuário avançar ou voltar durante o processo de cadastro. Isso proporciona ao usuário controle sobre o preenchimento das informações, permitindo revisões e correções antes de finalizar o cadastro.

<div align="center">
  <sub>Figura 57: Cadastro de Projeto</sub><br>
  <img src="./images/system/create-project.png" alt="Página de cadastro de projeto" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 4. Consistência e padrões

&emsp;&emsp;O usuário deve entender apenas uma vez os padrões utilizados na interface, sem gastar muito esforço cognitivo para aprender diversas coisas. No caso do LegacyLab, manter a interface do sistema parecido com o que os demais sistemas já usam tendem a tornar o produto mais intuitivo.

> Na tela "Perfil do Usuário", a disposição dos elementos e o uso de ícones é familiar a outros aplicativos utilizados pelos CEOs, e seguem o mesmo padrão das outras telas, garantindo que os usuários tenham uma experiência uniforme ao navegar pelo perfil e outras seções do aplicativo. 

<div align="center">
  <sub>Figura 58: Perfil</sub><br>
  <img src="./images/system/profile-page.png" alt="Página de perfil" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 5. Prevenção de erros

&emsp;&emsp;Capacidade que a interface deve ter de ajudar os usuários a não cometer erros. Sempre que o usuário for realizar uma ação que terá uma consequência significativa, é importante que o sistema o alerte sobre o que poderá acontecer. 

> Na tela "Perfil do Usuário", quando o CEO apaga um projeto, um popup aparece solicitando a confirmação da ação. O popup inclui informações claras sobre a ação que está prestes a ser realizada, proporcionando uma camada adicional de segurança, prevenindo exclusões acidentais e assegurando que os usuários tomem decisões informadas.

<div align="center">
  <sub>Figura 59: Pop Up de confirmação</sub><br>
  <img src="./images/system/popup.png" alt="Pop Up de confirmação" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 6. Reconhecimento em vez de lembrança

&emsp;&emsp;Minimiza a carga de memória do usuário, a interface de um sistema deve ser clara e intuitiva o suficiente para que o utente seja capaz de reconhecer elementos, ações e opções. 

> Em todos os cards de projeto exibidos no sistema, informações importantes como o nome do projeto, do CEO responsável e da empresa vinculada, estão sempre presentes e visíveis, facilitando o reconhecimento imediato pelo usuário.

<div align="center">
  <sub>Figura 60: Card</sub><br>
  <img src="./images/system/card.png" alt="Card de exemplo" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 7. Flexibilidade e eficiência de uso


&emsp;&emsp;Essa heurística destaca a importância de projetar sistemas que possam atender tanto usuários iniciantes quanto experientes. A flexibilidade permite que o sistema se adapte às diferentes necessidades, ou seja, leigos precisam de informações mais detalhadas e bem exibidas, enquanto os mais experientes podem acessar funções de forma mais prática, o sistema deve ser manuseável por qualuer um.

> Na tela de "Procura", a flexibilidade é proporcionada visto que além das listas com os projetos de um macrotema específico, há uma barra de busca onde os usuários podem fornecer o nome específico de um projeto. Isso oferece flexibilidade para usuários avançados que precisam de mais liberdade para achar algo mais direto ao ponto, mas também oferece aos usuários mais leigos a opção de navegar e ver todos os projetos listados de acordo com o filtro de categoris.

<div align="center">
  <sub>Figura 61: Feed Filtrado</sub><br>
  <img src="./images/system/filtered-feed.png" alt="Feed Filtrado" width="40%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### 8. Estética e design minimalista

&emsp;&emsp;Enfatiza a importância de um design simples e minimalista, onde cada elemento na interface tem um propósito claro e não há excesso de informações que possam sobrecarregar o usuário. Um design estético e minimalista ajuda a melhorar a experiência do usuário ao tornar a interface mais intuitiva e fácil de navegar.

> No LegacyLab, o design minimalista é evidente em todas as telas, com uma disposição limpa e organizada dos elementos, uso estratégico de cores e espaçamentos, e uma interface geral que evita a sobrecarga de informações. Os detalhes sobre o projeto, como exemplo, são apresentadas de forma clara e organizada, separados por espaços adequados, evitando a sensação de amontoamento.

#### 9. Recuperação de erros

&emsp;&emsp;Essa heurística sublinha a importância de fornecer feedback claro e construtivo quando os usuários cometem erros. O sistema deve ajudar os usuários a entenderem o que deu errado e orientá-los sobre como corrigir o problema de maneira eficaz.

> Na tela de "Login", se um usuário inserir credenciais incorretas, o sistema fornece feedback imediato e claro sobre o problema.

#### 10. Ajuda e documentação

&emsp;&emsp;É de muita importância fornecer aos usuários suporte e documentação facilmente acessíveis, mesmo que o ideal seja que o sistema seja intuitivo o suficiente para não necessitar de documentação, tê-la disponível é fundamental para resolver dúvidas e problemas.

> Embora não haja exemplos explícitos de interfaces de ajuda no aplicativo LegacyLab, essa própria documentação do desenvolvimento pode servir como uma base importante para criar materiais de suporte ao usuário. A documentação do desenvolvimento inclui detalhes sobre a arquitetura do sistema, fluxos de trabalho, especificações técnicas e instruções de uso, que podem ser adaptados para fornecer suporte eficaz aos usuários finais.

&emsp;&emsp;A aplicação das heurísticas de usabilidade de Nielsen no LegacyLab assegura que o aplicativo não só atende às necessidades dos usuários, mas também oferece uma experiência de uso otimizada e intuitiva. Cada heurística contribui para um aspecto específico da usabilidade, ao integrar esses princípios de maneira eficaz, o LegacyLab proporciona uma interface amigável e eficiente, que facilita a gestão de sinergias de projetos e melhora a interação dos CEOs e suas equipes com o sistema. Esse enfoque aumenta a satisfação do utente e promove uma utilização mais produtiva e eficaz do aplicativo, cumprindo os objetivos do projeto.
  
### 7.3.4 Zona do Polegar
---

&emsp;&emsp;O conceito da "zona do polegar" é fundamental na usabilidade de aplicativos móveis, pensando principalmente na operação utilizando apenas uma mão. A análise dessa zona ajuda a garantir que os elementos-chave do aplicativo estejam posicionados de forma que possam ser facilmente acessados pelo polegar do usuário, aumentando a ergonomia e a facilidade de uso. A análise é baseada em uma divisão da tela do smartphone em zonas de alcance do polegar, categorizadas em zonas verde, amarela e vermelha.

- **Zona Verde (Fácil Acesso):** pode ser alcançada confortavelmente pelo polegar sem necessidade de esticar a mão. Ideal para posicionar elementos frequentemente usados.

- **Zona Amarela (Alcance Médio):** o polegar pode alcançar esta área com algum esforço. É adequada para elementos usados com moderada frequência.

- **Zona Vermelha (Difícil Acesso):** só pode ser alcançada pelo polegar com um estiramento significativo da mão. Elementos posicionados aqui são mais difíceis de acessar e devem ser usados para funcionalidades menos frequentes.

#### Análise no LegacyLab

&emsp;&emsp;As três representações abaixo, mostram a interação do polegar em diferentes posições, considerando tanto a mão direita quanto a esquerda. No Legacy lab, pensamos em todos os usuários e formas de interação, por isso, tanto usuários canhotos quanto destros vão se sentir confortáveis ao utilizar o aplicativo. A imagem a seguir mostra a página inicial do aplicativo como exemplo, dividida em três partes para análise da acessibilidade:

<div align="center">
  <sub>Figura 62: Mapa de alcance zona do polegar</sub><br>
  <img src="./images/system/thumbzone-home.png" alt="Thumb Zone" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Com o mapa de calor da zona do polegar, podemos identificar a usabilidade da página, e como é possível observar, os elementos-chave foram estrategicamente posicionados para maximizar a agilidade. A barra de navegação inferior está posicionada na zona verde, pensando em facilitar o acesso a funções essenciais do aplicativo, como as páginas de *Home*, Pesquisa e Perfil. Outros elementos importantes são os *Cards* de projetos, que estão distribuidos de forma que estejam sempre em sua maior parte na zona verde, garantindo a rápida interação sem necessidade de esforço. Portanto, fica visível que os únicos elementos que estão na zona vermelha, ou seja, que possui o acesso mais difícil, são as funcionalidades menos rotineiras, que não precisam ser acessadas com frequência, como as notificações.

&emsp;&emsp;Apesar de focarmos na página inicial para falar sobre a zona do polegar, todas as páginas do LegacyLab foram desenvolvidas pensando nessa estratégia. Com essa análise, podemos concluir que a atenção para esse tópico resulta em um aplicativo que seja intuitivo e eficiente para os usuários. A disposição cuidadosa dos elementos em zonas de fácil acesso, garante uma interação mais confortável e rápida, que é particularmente importante para os CEOs que precisam de uma interface ágil. Portanto, a implementação dessa estratégia em todas as páginas assegura uma experiência de usuário aprimorada, promovendo uma utilização mais satisfatória e produtiva do aplicativo.

## 7.3.5 Acessibilidade

&emsp;&emsp;A acessibilidade refere-se ao design e desenvolvimento de aplicativos e sistemas que podem ser utilizados por todas as pessoas, incluindo aquelas com deficiências. No contexto de um aplicativo móvel, a acessibilidade é crucial para garantir que todos os usuários possam navegar, interagir e usufruir das funcionalidades oferecidas, independentemente de suas capacidades físicas ou sensoriais. Considerando o curto prazo de desenvolvimento, o Legacy optou por implementar as seguintes medidas:

1. **Contraste de Cores:** A escolha de cores no design do aplicativo foi cuidadosamente pensada para garantir um bom contraste entre o texto e o fundo, essencial para uma leitura clara e acessível. Utilizamos texto escuro sobre um fundo claro, o que facilita a leitura para pessoas com baixa visão ou dificuldades de percepção de cores. Além disso, a paleta de cores foi selecionada para incluir elementos visuais e ícones com cores distintas, ajudando a diferenciar funcionalidades e seções do aplicativo. Esse cuidado com o contraste visual não só melhora a estética, mas também assegura que as informações sejam facilmente acessíveis a todos os usuários.

2. **Tamanhos de Fonte e Zoom:** Os tamanhos das fontes foram escolhidos para serem suficientemente grandes, proporcionando uma leitura confortável em dispositivos móveis. Consideramos a diversidade de dispositivos utilizados pelos usuários, desde *smartphones* com telas menores até telas maiores. Essa abordagem visa garantir que todos os usuários, independentemente do dispositivo que utilizem, possam ler o conteúdo sem esforço. 

3. **Textos e Legendas:** O uso de textos claros, objetivos e descrições detalhadas é uma prioridade no design do nosso aplicativo. Cada seção e funcionalidade inclui textos explicativos que facilitam a compreensão do usuário, independentemente de sua familiaridade com a tecnologia ou com o conteúdo apresentado. Essa abordagem contribui para a acessibilidade geral do aplicativo. 

&emsp;&emsp;Implementar acessibilidade é importante porque promove a inclusão social e digital, permitindo que pessoas com deficiências visuais, auditivas, motoras ou cognitivas tenham uma experiência de uso equivalente à de outros usuários. Além disso, um aplicativo acessível amplia a base de usuários, atende a requisitos legais e normativos, e demonstra responsabilidade social. Em resumo, a acessibilidade assegura que todos possam beneficiar-se igualmente dos recursos e serviços oferecidos pelo aplicativo, contribuindo para um ambiente digital mais justo e inclusivo.

> Para uma visão mais completa da usabilidade do aplicativo, acesse [este link](https://drive.google.com/file/d/1Z8XU0Q9rvl08zgMmcDGJ-4G7tTVlE1Br/view?usp=sharing). No vídeo, você encontrará uma demonstração detalhada do funcionamento do LegacyLab, acompanhada de uma explicação completa da análise realizada.

# 8. Projeto de Banco de Dados

&emsp;&emsp;Esta seção aborda o desenvolvimento do banco de dados, necessário para suportar os dados registrados e o sistema de recomendação do aplicativo. Um banco de dados bem projetado é crucial para o armazenamento eficiente e a recuperação rápida de informações, garantindo que o sistema de recomendação possa operar de forma eficaz e fornecer resultados precisos.

## 8.1 Especificação da Base de Dados para Modelo de Recomendação

&emsp;&emsp; Com o objetivo de atingir boas métricas e avaliações no modelo, o grupo de desenvolvedores do LegacyLab teve que primeiro dedicar alta atenção a base de dados fornecida e voltar ações em relação ás seguintes etapas:

1. **Pré-Exploração da Base de Dados**:
   Antes de iniciar a análise dos dados do LegacyLab, é fundamental realizar uma pré-exploração da base de dados. Isso implica compreender a estrutura dos dados disponíveis, os tipos de informações registradas e como estão organizadas. Por exemplo, na base de dados do LegacyLab, seria importante entender como os projetos estão categorizados, quais informações estão disponíveis sobre cada projeto e como as interações entre os usuários são registradas.

2. **Exploração da Base de Dados**:
   Nesta etapa, é necessário analisar os dados de forma mais aprofundada para identificar padrões, tendências e insights que possam ser úteis para o sistema de recomendação do LegacyLab. Por exemplo, podemos explorar quais tipos de temas são mais populares entre os CEOs participantes.

3. **Levantamento de Hipóteses**:
   Com base na exploração inicial dos dados, é possível formular hipóteses sobre os padrões de colaboração entre os CEOs e sobre quais características dos projetos são mais relevantes para estimular sinergias produtivas. Por exemplo, pode-se hipotetizar que CEOs com interesses semelhantes têm maior probabilidade de colaborar em projetos específicos. Essas hipóteses servirão como orientações para o desenvolvimento do sistema de recomendação do LegacyLab, ajudando a garantir que ele seja capaz de sugerir colaborações relevantes e valiosas para os usuários.

&emsp;&emsp;Essas etapas são essenciais para garantir que o sistema de recomendação do LegacyLab seja construído com base em uma compreensão sólida dos dados disponíveis e das dinâmicas de colaboração entre os CEOs participantes. A pré-exploração, a exploração e o levantamento de hipóteses fornecem as bases para o desenvolvimento de um sistema de recomendação eficaz, capaz de amplificar as oportunidades de sinergia dentro da comunidade do CEO’s Legacy e impulsionar a inovação e o impacto social positivo.

&emsp;&emsp;Todas as análises, explicações e *insights* feitas com base no dataset fornecido, estão disponíveis [neste notebook](https://colab.research.google.com/drive/1J4U1TNepy_4qg_reuuoIQ43rXL46sGJy?usp=sharing) de processamento de dados. Elas incluem entendimento de colunas e rótulos, adaptações para o banco de dados vigente no LegacyLab, organização de macro e microtemas, tratamento de tabelas, questionamentos e respostas para problemas como o desbalanceamento de dados.

## 8.2 Modelo Conceitual

&emsp;&emsp;Um modelo conceitual é uma representação dos dados de um sistema, que procura capturar aspectos essenciais do mundo real e suas inter-relações, sem adentrar nos detalhes técnicos de implementação. Ele atua como um guia para compreensão e organização dos dados, facilitando a comunicação entre os diversos envolvidos no projeto, como analistas de negócios, desenvolvedores e clientes.

&emsp;&emsp;Para isso, foi utilizado o conceito de Entidade-Relacionamento, uma abordagem utilizada para modelar dados em um sistema de informação. As entidades representam objetos ou conceitos onde as informações serão armazenadas, sendo representadas por retângulos no diagrama. As relações são associações entre essas entidades e descrevem como elas se conectam ou interagem umas com as outras, sendo representadas por linhas que ligam as entidades e com um nome que descreve a natureza da associação. Os atributos são as propriedades ou características, representadas por elipses ligadas às entidades.

<div align="center">
  <sub>Figura 63: Modelo de Banco de Dados Conceitual</sub><br>
  <img src="./images/system/conceptual-data-model.jpeg" alt="Banco de dados conceitual" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

### Entidades

&emsp;Entidade são os componentes fundamentais que representam os diferentes grupos e elementos envolvidos na plataforma. Abaixo, estão as entidades identificadas no modelo conceitual do banco de dados do LegacyLab e suas respectivas descrições:

**1. User (Usuário):** Usuários da plataforma, C-levels e executivos de empresas que utilizarão o sistema.

**2. Project (Projeto):** Projetos cadastrados na plataforma, que representam as atividades e iniciativas dos C-levels.

**3. Interest (Interesse):** Tabela de registro de interesse dos usuários em projetos específicos, fundamental para o sistema de recomendação.

**4. Recommendation (Recomendação):** Armazena as recomendações geradas pelo sistema de recomendação, que são exibidas aos usuários com base em seus interesses e atividades.

**5. Macrotheme (Macrotema):** Categorias gerais que representam os temas principais dos projetos, utilizadas para agrupar os projetos em categorias amplas. Exemplo: "Educação".

**6. Microtheme (Microtema):** Subcategorias que representam segmentações dentro de um macrotema, utilizadas para categorizar os projetos. Exemplo: "Educação Infantil".

**7. Sinergy (Sinergia):** Registro de sinergias entre dois projetos, indicando a criação de uma relação (Aprender, integrar ou unificar) entre eles.

**8. Update (Atualização):** Registra as atualizações entre as sinergias, indicando as ações realizadas, estreitamento de relações e outras informações relevantes no decorrer do tempo.

<div align="center">
  <sub>Tabela 37: Entidades Fortes</sub><br>

### Entidades Fortes

| Entidade                      | Relacionamentos        |
| ----------------------------- | -----------------------|
| User (Usuário)                | - Pode ser associado a nenhum ou vários **Projetos** (0 para n) <br> - Pode ter mostrado **Interesse** a nenhum ou vários **Projetos** (0 para n) <br> - Pode receber **Recomendações** de nenhum ou vários **Projetos** (0 para n)                    |
| Project (Projeto)             | - É obrigatoriamente relacionado a um **Usuário** (1 para 1) <br> - Pode ter o **Interesse** de nenhum ou vários **Usuários** (0 para n) <br> - Pode ser **Recomendado** para nenhum ou vários **Usuários** (0 para n) <br> - Pode ser ligado a outro **Projeto** para formar **Sinergia** (0 para n) <br> - Deve ser agrupado em um **Microtema** (1 para 1)|
| Macrotheme (Macrotema)        | - Deve ser agrupado em um **Projeto** (1 para 1) <br> - Pode agrupar nenhum ou vários **Microtemas** (0 para n) |
| Microtheme (Microtema)        | - Deve ser agrupado em um **Macrotema** (1 para 1) <br> - Pode agrupar nenhum ou vários **Projetos** (0 para n) |
| Update (Atualização)          | - Deve ser relacionado a uma **Sinergia** (1 para 1) |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<div align="center">
  <sub>Tabela 38: Entidades Associativas</sub><br>

### Entidades Associativas

| Entidade                      | Relacionamentos        |
| ----------------------------- | -----------------------|
| Interest (Interesse)          | - Deve ser associado a um **Usuário** <br> - Deve ser associado a um **Projeto** |
| Recommendation (Recomendação) | - Deve ser associado a um **Usuário** <br> - Deve ser associado a um **Projeto** |
| Sinergy (Sinergia)            | - Deve ser associado a um **Projeto** <br> - Deve ser associado a outro **Projeto** |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp; Sendo assim, ao definir detalhadamente as características de cada entidade e os vínculos entre elas, o modelo fornece uma base sólida para o desenvolvimento eficaz da aplicação, garantindo a captura precisa e a integridade dos dados, além de facilitar a compreensão durante o desenvolvimento do projeto.

## 8.3 Modelo Lógico

&emsp;&emsp;Um modelo lógico em banco de dados é uma representação mais detalhada e estruturada do que foi concebido no modelo conceitual. Enquanto o modelo conceitual se concentra nos requisitos do sistema de forma abstrata, o modelo lógico desce um nível, descrevendo as tabelas, colunas, chaves primárias, estrangeiras e outros elementos específicos do banco de dados.

&emsp;&emsp;Dessa forma, modelo lógico se faz técnico e detalhado. Ele traduz as entidades, atributos e relacionamentos do modelo conceitual em uma estrutura mais próxima do que será implementado no banco de dados físico. Normalmente, inclui a definição de tabelas, tipos de dados, chaves primárias, chaves estrangeiras e outras restrições de integridade referencial.

&emsp;&emsp;O surgimento desses modelos está diretamente relacionado ao desenvolvimento de sistemas de banco de dados e à necessidade de planejar e projetar esses sistemas de forma estruturada e eficiente. A abordagem de modelagem de dados evoluiu ao longo do tempo para incluir esses diferentes níveis de abstração (conceitual, lógico e físico) para garantir que os sistemas sejam bem projetados, eficientes e atendam aos requisitos do usuário.

&emsp;&emsp;Para viabilizar a passagem do modelo conceitual para o modelo lógico, foi utilizada uma técnica de mapeamento, baseada em etapas: entidades fortes, entidades fracas, relacionamentos 1:1, 1:N e N:Ms. Cada entidade, atributo e relacionamento foi traduzido em uma estrutura de tabela, coluna e chave estrangeira, garantindo que a estrutura lógica represente fielmente a essência do modelo conceitual.

### 8.3.1 Etapas de Mapeamento

#### Entidades Fortes

&emsp;&emsp;Entidades fortes em um modelo lógico, geralmente referem-se a entidades que existem de forma independente e têm identidade própria dentro do contexto do modelo. Em um modelo de banco de dados, por exemplo, uma entidade forte é aquela que pode ser identificada por seus próprios atributos, sem depender de outras entidades para sua existência.

&emsp;&emsp;As entidades fortes do modelo conceitual foram mapeadas diretamente para tabelas no modelo lógico, com cada atributo da entidade representado como uma coluna na tabela. As chaves primárias foram definidas para garantir a unicidade dos registros, e as chaves estrangeiras foram estabelecidas para representar os relacionamentos entre as entidades. Sendo assim, as seguintes entidades foram mapeadas:

<div align="center">
  <sub>Tabela 39: Entidades Fortes</sub><br>

| Entidade Conceitual | Tabela Lógica | Atributos |
| ------------------- | ------------- | --------- |
| Usuarios | User | **id** (inteiro), name (string), password (string), email (string), position (string), enterprise (string) |
| Macrotemas | Macrothemes | **id** (inteiro), name (string) |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### Entidades Fracas

&emsp;&emsp;Entidades fracas são entidades que dependem de uma entidade forte para existir. No modelo lógico, as entidades fracas são representadas como tabelas que incluem a chave primária da entidade forte como chave estrangeira. Sendo assim, as seguintes entidades fracas foram mapeadas:

<div align="center">
  <sub>Tabela 40: Entidades Fracas</sub><br>

| Entidade Conceitual | Tabela Lógica | Atributos |
| ------------------- | ------------- | --------- |
| Projetos | Project | **id** (inteiro), name (string), description (string), data (data), short_description (string), status (string)|
| Atualizações | Updates  | **id** (inteiro), data (data), title (string), description(string) |
| Microtemas | MicroTheme  | **id** (inteiro), name (string) |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

#### Relacionamentos 1:1

&emsp;&emsp;Relacionamentos 1:1 são aqueles em que uma entidade está associada a exatamente uma instância de outra entidade. No modelo lógico, os relacionamentos 1:1 são representados por meio de chaves estrangeiras que estabelecem a associação entre as entidades. Todavia, não houve relacionamentos 1:1 mapeados no modelo lógico, uma vez que as entidades do modelo conceitual não apresentaram esse tipo de relacionamento.

#### Relacionamentos 1:N

&emsp;&emsp;Relacionamentos 1:N são aqueles em que uma entidade está associada a uma ou mais instâncias de outra entidade. No modelo lógico, os relacionamentos 1:N são representados por meio de chaves estrangeiras que estabelecem a associação entre as entidades. É válido destacar que, aqui, assim como em outros relacionamentos, algumas entidades supracitadas podem reaparecer, o que faz com que nas **tabelas finais** somente a última versão de uma mesma tabela seja apresentada.  

<div align="center">
  <sub>Tabela 41: Relacionamentos 1:N </sub><br>

| Entidade Conceitual | Tabela Lógica | Chaves Estrangeiras |
| ------------------- | ------------- | ------------------- |
| Atualizações | Updates      | **id_sinergy** (inteiro) - Chave estrangeira para a tabela Sinergy         |
| Projetos | Project | **id_User** (inteiro) - Chave estrangeira para a tabela User **id_MicroTheme** (inteiro) - Chave estrangeira para a tabela MicroTheme |
| Microtemas | MicroTheme | **id_MacroTheme** (inteiro) - Chave estrangeira para a tabela MacroTheme |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Portanto, a título de exemplificação, a nova versão da tabela de Microtemas inclui uma chave estrangeira (atributo que é chave primária em outra tabela) para referenciar a tabela de Macrotemas, permitindo a associação entre as duas entidades.

#### Relacionamentos N:M

&emsp;&emsp;Os relacionamentos N:M ocorrem quando múltiplas instâncias de uma entidade estão associadas a múltiplas instâncias de outra entidade. Nesses casos, é necessário criar uma tabela intermediária para representar essa associação, uma vez que os SGBDs geralmente não suportam diretamente esse tipo de relacionamento.

&emsp;&emsp;A necessidade de uma tabela intermediária em relacionamentos N:M decorre da necessidade de representar essa associação de forma eficiente e coerente no banco de dados. Essa tabela é responsável por conectar as chaves primárias das entidades envolvidas, permitindo a navegação entre elas de maneira consistente.

<div align="center">
  <sub>Tabela 42: Relacionamentos N:M</sub><br>


| Entidade Conceitual | Tabela Lógica | Chaves Estrangeiras |
| ------------------- | ------------- | ------------------- |
| Associação entre projetos | Sinergy | source_project (FK para projetos), target_project (FK para projetos) |
| Associação entre usuários e projetos para alimentação do modelo de recomendação | Interest | id_User (FK para User), id_Project (FK para Project) |
| Associação entre usuários e projetos para a previsão do modelo de recomendação | Recommendation | id_User (FK para User), id_Project (FK para Project) |

  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>


&emsp;&emsp;Essas tabelas intermediárias são cruciais para garantir a integridade referencial e a consistência dos dados no banco de dados. Elas permitem uma representação adequada dos relacionamentos N:M entre as entidades envolvidas, facilitando consultas e operações de manipulação de dados.

### 8.3.2 Tabelas Finais

&emsp;&emsp;Com base nas etapas de mapeamento e nas escolhas de design, as tabelas finais do modelo lógico foram definidas. Cada tabela representa uma entidade ou relacionamento do modelo conceitual, com colunas que correspondem aos atributos identificados. A seguir, o modelo lógico completo é apresentado, incluindo todas as tabelas e colunas resultantes do processo de mapeamento.

<div align="center">
  <sub>Figura 64: Modelo Lógico</sub><br>
  <img src="./images/system/logical-data-model.png" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Seguindo o mapeamento citado anteriormente, o modelo lógico apresenta 8 tabelas, cada uma diz a respeito de: usuários, projetos, macrotemas, microtemas, sinergias, atualizações, interesses e recomendações. Além disso, na imagem acima, também são visíveis os atributos, o tipo de atributo, as chaves primárias e estrangeiras e os relacionamentos de cada tabela.

# 9. Construção da Solução 

&emsp;&emsp;Nesta seção, discutiremos o processo de construção da solução, detalhando os componentes críticos e as metodologias utilizadas para desenvolver o aplicativo. Focaremos na implementação do modelo de recomendação, na estrutura geral da solução e nos padrões arquitetônicos que sustentam o sistema. A seguir, descreveremos cada um dos elementos envolvidos na construção da solução.

## 9.1 Modelo de Recomendação

&emsp;&emsp;No contexto do LegacyLab, um sistema de recomendação baseado em históricos de interações desempenha um papel fundamental na amplificação das oportunidades de sinergia dentro da comunidade do programa CEO’s Legacy. Este sistema utiliza técnicas de recomendação para sugerir projetos que possam resultar em colaborações produtivas entre os CEOs participantes, impulsionando a inovação e fortalecendo os laços de colaboração.

&emsp;&emsp;Estas recomendações não apenas facilitam a descoberta de projetos relevantes, mas também promovem uma maior integração e colaboração entre os membros da comunidade. Ao sugerir colaborações potenciais com base nos interesses e histórico de interações dos usuários, o LegacyLab fortalece os vínculos entre os líderes empresariais e amplia o alcance das iniciativas de desenvolvimento executivo promovidas pela Fundação Dom Cabral.

&emsp;&emsp;Além disso, ao analisar o impacto e a eficácia das recomendações feitas pelo sistema, a Fundação Dom Cabral pode obter uma visão mais clara e quantificável do valor agregado pelo LegacyLab, consolidando seu papel como catalisador de liderança empresarial e transformação social.

### Como funcionam os modelos de recomendação?

&emsp;&emsp;Os modelos de recomendação são sistemas inteligentes projetados para sugerir itens ou informações aos usuários com base em seus interesses e comportamentos passados. 

Existem três tipos principais de modelos de recomendação: filtragem colaborativa, filtragem baseada em conteúdo e sistemas híbridos.

&emsp;&emsp;**Filtragem Colaborativa:** Este modelo recomenda itens com base nas preferências de usuários semelhantes. Ele analisa o histórico de interações do usuário (como compras anteriores, avaliações, visualizações) e encontra padrões entre usuários com gostos semelhantes. Existem duas abordagens principais dentro da filtragem colaborativa: filtragem colaborativa baseada em usuário e filtragem colaborativa baseada em item.

&emsp;&emsp;**Filtragem colaborativa baseada em usuário:** Identifica usuários semelhantes com base em suas interações passadas e recomenda itens que usuários semelhantes gostaram no passado.
Filtragem colaborativa baseada em item: Recomenda itens semelhantes aos que o usuário gostou anteriormente, identificando padrões de comportamento de usuários que gostaram dos mesmos itens.

&emsp;&emsp;**Filtragem Baseada em Conteúdo:** Este modelo recomenda itens com base nas características do próprio item e nas preferências do usuário. Ele analisa os atributos dos itens (como gênero, categoria, palavras-chave) e as preferências do usuário para sugerir itens relevantes. Por exemplo, se um usuário gosta de filmes de ficção científica, o sistema recomendará outros filmes do mesmo gênero.

&emsp;&emsp;**Sistemas Híbridos:** Esta abordagem combina elementos da filtragem colaborativa e da filtragem baseada em conteúdo para fornecer recomendações mais precisas e diversificadas. Os sistemas híbridos podem compensar as limitações de cada método individual, melhorando assim a qualidade das recomendações.
Os modelos de recomendação são alimentados por algoritmos complexos, como algoritmos de aprendizado de máquina e processamento de linguagem natural, que analisam grandes conjuntos de dados para identificar padrões e fazer previsões sobre as preferências do usuário.

&emsp;&emsp;Esses modelos desempenham um papel fundamental na personalização da experiência do usuário, aumentando o engajamento e a satisfação, ao mesmo tempo em que ajudam as empresas a impulsionar as vendas e fornecer serviços mais relevantes. No entanto, é importante considerar questões éticas, como a privacidade do usuário e a transparência no processo de recomendação.

>No contexto da solução LegacyLab, a base desse sistema é o **modelo de recomendação baseado em filtragem colaborativa**. O notebook que treina o modelo do LegacyLab está disponível [aqui](https://colab.research.google.com/drive/1l7wM5oMFKFqI4Jaa-H2AWuNzkn0dhf2v?usp=sharing).

### Singular Value Decomposition (SVD):

&emsp;&emsp;O SVD é uma técnica de decomposição de matriz que é frequentemente usada em sistemas de recomendação. Ele é usado para decompor a matriz de interação usuário-item em fatores latentes que representam as características ocultas dos usuários e dos itens.

#### Como funciona:

&emsp;&emsp;Dada uma matriz de interação usuário-item, o SVD a decompõe em três matrizes: uma matriz de usuários, uma matriz de itens e uma matriz diagonal de valores singulares.

&emsp;&emsp;A ideia é que as características latentes (fatores) possam ser extraídas dessas matrizes. Por exemplo, em um sistema de recomendação de filmes, essas características latentes podem representar gênero, diretor, ator principal, etc.

&emsp;&emsp;O modelo usa esses fatores latentes para prever as classificações que os usuários dariam aos itens que ainda não avaliaram. Isso é feito multiplicando as matrizes de usuários e itens para obter uma matriz de previsões.

&emsp;&emsp;No contexto de um sistema de recomendação, o SVD pode ser usado para encontrar usuários semelhantes com base em suas avaliações de itens. Uma vez que os usuários semelhantes são identificados, o sistema pode recomendar itens que foram bem avaliados por esses usuários, mas ainda não foram avaliados pelo usuário alvo.

### Pipeline do modelo

&emsp;&emsp;Pipelines de machine learning são etapas criadas para serem utilizadas com modelos de inteligência artificial e machine learning, em geral, para otimizar resultados. No contexto do LegacyLab, o pipeline desenvolvido atinge o objetivo qual se espera que o algoritmo sozinho consiga resolver de maneira completa essas etapas e garantir entrega contínua ao projeto.

&emsp;&emsp;Na esteira definida, o serviço de recomendação realiza as seguintes etapas:

**1. Busca novas avaliações de projetos:** O serviço recupera do banco de dados as informações ta tabela "*interests*" e transforma essas informações em um arquivo .csv com o id do usuário, o id do projeto e a avaliação em si;

**2. Retreino do Modelo:** A partir das novas avaliações, o modelo de recomendação passa por um retreino automático, o que ue garante a confiabilidade das recomendações com base em dados recentes e atualizados;

**3. Novas predições:** Com o modelo treinado e atualizado, novas recomendações de projetos são geradas para cada usuário. Essa etapa é imporante uma vez que mantém a solução sempre se renovando e mostrando novas indicações aos usuários;

**4. População do Banco:** Assim que as novas recomendações são geradas, elas são inseridas no banco, na tabela "*recommendations*". A partir de então, a rota definida no *backend* responsável por retornar os projetos recomendados entra em ação e finaliza o pipeline.

&emsp;&emsp;Assim, para que esse processo aconteça por completo, basta entrar no diretório ```RecommendationService``` e executar o arquivo ```train_rec_system.bat```.

## 9.2 Estrutura da Solução
&emsp;&emsp;Para discutir a estrutura da solução, é necessário relembrar o seu contexto. A solução **LegacyLab** envolve o desenvolvimento de um aplicativo de gestão de sinergias entre projetos das empresas do CEOs’ Legacy. Ela foi construída utilizando uma arquitetura orientada a serviços (SOA). Essa arquitetura permite que diferentes serviços sejam desenvolvidos, implantados e mantidos de forma independente, proporcionando flexibilidade e escalabilidade.

&emsp;&emsp;O **LegacyLab** foi desenvolvido em torno destes três pilares:
1. **Aplicativo Móvel:** Interface do usuário pela qual ele interage e faz as requisições.
2. **Backend:** Composto por múltiplos serviços especializados para diferentes funcionalidades.
3. **Sistema de Recomendação:** Implementado como um serviço separado para recomendar possíveis sinergias utilizando os princípios da filtragem colaborativa.

### 9.2.1 Estrutura de Serviço do Backend
&emsp;&emsp;A arquitetura do backend é composta por três serviços principais. Essa divisão proporciona flexibilidade e independência na implementação de cada serviço, permitindo que sejam desenvolvidos, implantados e mantidos de forma autônoma. Como resultado, os serviços são modularmente testáveis e reutilizáveis, garantindo escalabilidade e adaptabilidade à medida que novas funcionalidades ou alterações são necessárias. O LegacyLab conta com os seguintes serviços:

1. **AuthService:**
    - Atua como serviço de autenticação de usuários.
    - Funcionalidades: gerenciamento de login, validação de credenciais, emissão de tokens de acesso e controle de permissões dos usuários.

2. **CoreService:**
    - Gerencia todas as informações relacionadas aos projetos e CEOs.
    - Funcionalidades: gerenciamento de projetos, interesses, sinergias e usuários

3. **RecommendationService:**
    - Gera recomendações de projetos para usuários e possíveis sinergias entre eles.
    - Funcionalidades: processamento de dados, geração de recomendações usando filtragem colaborativa, registro das previsões obtidas e população da tabela de recomendações no banco de dados.  
    
### 9.2.2 Arquitetura MVC

&emsp;&emsp;A arquitetura MVC *(Model-View-Controller)* separa a aplicação em camadas distintas, facilitando a modularidade, reutilização e manutenção do código. Trata-se de um padrão de design de software que organiza a aplicação em três componentes principais:

- **Model (M):** Representa os dados e as regras de negócio da aplicação. Ele é responsável por gerenciar a lógica de acesso aos dados e notificar a View sobre as alterações.
- **View (V):** Interface do usuário que exibe os dados. No caso do backend, as Views são substituídas por APIs REST.
- **Controller (C):** Atua como intermediário entre a View e o Model, processando as solicitações do usuário, chamando os métodos apropriados do Model e retornando a resposta adequada para a View.

&emsp;&emsp;No backend do LegacyLab, adaptamos esse modelo, optando por não seguir a arquitetura tradicional, pois as Views foram substituídas por APIs REST, os DTOs são usados para transportar dados entre as camadas, enquanto os Models representam a estrutura dos dados no domínio. Por fim, os Repositórios centralizam o acesso ao banco de dados, facilitando a manutenção e reutilização do código. Assim, chegamos na seguinte organização para cada serviço:

1. **Controller:** Controla a lógica de entrada e saída, recebendo requisições HTTP do front-end e enviando respostas.
- Comunicação: Interage com os repositórios para acessar os dados e processá-los antes de enviar ao cliente.

2. **Repository:** Camada de acesso aos dados. Conecta-se diretamente ao banco de dados para operações de leitura e escrita.
  - Comunicação: Pode utilizar os DTOs para transportar dados do banco de dados.

3. **DTO *(Data Transfer Object)*:** Objeto usado para transportar dados entre camadas. Ele é usado para capturar e formatar dados diretamente do banco de dados no repositório.
- Comunicação: Fornece dados ao Controller e aos Models, sem expor diretamente a estrutura do banco de dados.

4. **Model:** Representa a estrutura dos dados do domínio, sendo usados no Controller.
- Comunicação: Representa como os dados devem ser retornados ao usuário ou recebidos pelo Controller.

&emsp;&emsp;Podemos concluir que a estrutura modular e orientada a serviços do LegacyLab proporciona flexibilidade, escalabilidade e adaptabilidade para futuras expansões e melhorias. A divisão do backend em serviços independentes, permite autonomia e facilita a manutenção e o uso da arquitetura MVC garante uma clara separação de responsabilidades entre as camadas, facilitando a organização e o entendimento do código. A combinação da arquitetura orientada a serviços com os princípios do MVC cria uma solução bem estruturada para a gestão de sinergias entre os projetos das empresas do CEOs’ Legacy, permitindo que novas funcionalidades sejam incorporadas de forma independente, garantindo a evolução contínua do LegacyLab.

### 9.2.3 API externa

&emsp;&emsp;Com o objetivo de ampliar a experiencia do usuário em relação a descrição de projetos cadastrados na base do LegacyLab, a equipe de desenvolvedores optou pela integração de uma API externa de geração de texto, popularmente conhecida como API do "Chat GPT".

#### O que é o Serviço

&emsp;&emsp;A API da OpenAI é um serviço de inteligência artificial que fornece modelos de linguagem avançados para gerar texto, traduzir idiomas e realizar outras tarefas de processamento de linguagem natural. O serviço Chat Completion da OpenAI é um modelo de linguagem treinado para gerar respostas em conversas de chat, permitindo que os desenvolvedores aproveitem a capacidade de geração de texto da IA em suas soluções.

&emsp;&emsp;Este serviço utiliza a API da OpenAI para gerar descrições de projetos com base nos detalhes fornecidos pelo usuário, facilitando a criação de conteúdo para a plataforma LegacyLab. A integração da API de Chat Completion permite que os usuários gerem descrições de projetos de maneira rápida e eficiente, melhorando a experiência do usuário e a qualidade das informações fornecidas.

&emsp;&emsp;O objetivo é não só facilitar a criação de descrições profissionais e bem formatadas para projetos mas mais do que isso, aproveitar a capacidade de geração de texto da IA para fornecer descrições claras, concisas e atraentes que destaquem o potencial e a relevância de cada projeto para a comunidade do CEOs' Legacy.

#### Funcionamento do Serviço

1. **Configuração da API**:
   - A API da OpenAI é configurada utilizando a chave de API fornecida nas configurações da aplicação.

2. **Criação de Conversação**:
   - Utilizamos o modelo `gpt-4-turbo` para criar uma nova conversa.
   - Definimos parâmetros como `Temperature` (0 para respostas mais previsíveis) e `MaxTokens` (limite de 500 tokens).

3. **Mensagens de Sistema e Usuário**:
   - Adicionamos uma mensagem de sistema que orienta o modelo a gerar descrições profissionais.
   - Adicionamos a entrada do usuário com os detalhes do projeto.

4. **Obtenção da Resposta**:
   - A resposta gerada pela API é obtida de forma assíncrona e retornada ao usuário.

### Código de Implementação

```csharp
using OpenAI_API;
using OpenAI_API.Chat;
using System.Threading.Tasks;

namespace CoreService.Services
{
    public class OpenAIService : IOpenAIService
    {
        private readonly OpenAIAPI _openAIAPI;

        public OpenAIService(IConfiguration configuration)
        {
            _openAIAPI = new OpenAIAPI(configuration["OpenAI:ApiKey"]);
        }

        public async Task<string> GenerateProjectDescription(string projectName, string projectDetails)
        {
            var chat = _openAIAPI.Chat.CreateConversation();

            chat.Model = "gpt-4-turbo";

            chat.RequestParameters.Temperature = 0;
            
            chat.RequestParameters.MaxTokens = 500;

            chat.AppendSystemMessage("Você é um assistente que gera descrições de projetos limpas e profissionais para uma plataforma de rede social para CEOs. Certifique-se de que as descrições estão formatadas sem quaisquer aspas, barras ou caracteres incomuns. O conteúdo retornado deve ser diretamente a descrição, sem cabeçalhos. Para quebra de linha inclua '\\n'");

            chat.AppendUserInput($"Gere uma descrição do projeto com base nos seguintes detalhes. Nome do Projeto: {projectName}. Detalhes do Projeto: {projectDetails}");

            var response = await chat.GetResponseFromChatbotAsync();

            return response;
        }
    }
}
```

#### Padrões de Trabalho

- **Clareza e Profissionalismo**:
  - As descrições geradas devem ser claras, profissionais e formatadas corretamente, evitando caracteres incomuns.
  
- **Configuração Personalizável**:
  - Os parâmetros de temperatura e tokens máximos podem ser ajustados conforme necessário para personalizar a resposta.

- **Asynchronous Processing**:
  - A obtenção das respostas é feita de forma assíncrona, garantindo que o serviço permaneça responsivo.

#### Integração e Uso

&emsp;&emsp;Este serviço foi disponibilizado como uma rota de API REST para ser integrado ao aplicativo LegacyLab. Essa rota está disponibilizada no Serviço Core, que por sua vez será acessado pelo frontend do aplicativo para gerar descrições de projetos.

#### Exemplos de Uso:

#### Swagger UI

&emsp;&emsp;A rota de API REST para geração de descrições de projetos foi documentada e disponibilizada no Swagger UI, permitindo que os desenvolvedores visualizem e testem a integração com a API de forma interativa. Abaixo é possível visualizar um exemplo de requisição e resposta da rota de geração de descrições de projetos, mostrando exatamente como a rota funciona e como os dados são enviados e recebidos.

<div align="center">
  <sub>Figura 65: Requisição da Rota</sub><br>
  <img src="./images/system/openai_request.png" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<div align="center">
  <sub>Figura 66: Resposta da Rota</sub><br>
  <img src="./images/system/openai_response.png" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;O uso de uma API externa para gerar descrições de projetos é uma solução inovadora e eficaz para a criação de conteúdo personalizado e de alta qualidade. Ao integrar a API de Chat Completion da OpenAI no LegacyLab, a equipe de desenvolvimento foi capaz de automatizar e simplificar o processo de geração de descrições de projetos, proporcionando uma experiência mais eficiente e atraente para os usuários.

&emsp;&emsp;Para o desenvolvimento de um software de qualidade, especialmente dentro do prazo de 10 semanas, a integração de APIs externas pode ser uma estratégia eficaz para acelerar o desenvolvimento e adicionar funcionalidades avançadas ao aplicativo, que geram valor para os usuários e diferenciam o produto no mercado.

# 10. Testes de Software

&emsp;&emsp;Nesta seção, abordaremos os testes de software realizados para garantir que a solução desenvolvida seja funcional, eficiente e livre de erros. Os testes são uma parte crucial do ciclo de desenvolvimento, permitindo identificar e corrigir problemas antes que a solução seja lançada. A seguir, detalharemos os diferentes tipos de testes realizados, incluindo testes de usabilidade, testes de integração, testes de serviços e a integração e validação do modelo de recomendação.

## 10.1 Testes de Usabilidade para Mockup

&emsp;&emsp;A seguir, apresentaremos os testes de usabilidade realizados nos mockups do aplicativo. Esses testes têm como objetivo avaliar a facilidade de uso e a intuitividade da interface do usuário, identificando possíveis melhorias na navegação e na interação com o aplicativo. Detalharemos os métodos utilizados para conduzir os testes de usabilidade, os participantes envolvidos e as principais descobertas.

### Roteiro e Realização dos Testes

&emsp;&emsp;As perguntas no roteiro dos testes de usabilidade são fundamentais para guiar as interações dos usuários com o aplicativo e coletar feedback específico sobre sua experiência. Elas são desenhadas para explorar tanto a funcionalidade quanto a intuitividade do sistema, ajudando a equipe a entender como os usuários percebem e utilizam o aplicativo em várias situações. Observa-se alguns aspectos importantes das perguntas utilizadas:

1. **Perguntas sobre Funcionalidade:**
   - Essas perguntas focam em entender se os usuários conseguem realizar tarefas específicas como visualizar informações de projetos, criar novos projetos ou buscar projetos por temas específicos. Elas ajudam a identificar se as funcionalidades do aplicativo estão funcionando conforme o esperado e se estão facilmente acessíveis para os usuários.

2. **Perguntas sobre Usabilidade:**
   - Perguntas que exploram como os usuários interagem com a interface, como a facilidade de encontrar elementos específicos na tela ou entender as informações apresentadas. Essas perguntas são cruciais para avaliar a disposição dos elementos, a clareza das informações e a intuitividade da navegação.

3. **Perguntas sobre Estética e Design:**
   - Avaliam a reação dos usuários à identidade visual do aplicativo, incluindo layout, cores e tipografia. Feedbacks sobre estes aspectos são importantes para garantir que o design seja não apenas funcional, mas também visualmente agradável.

4. **Perguntas Abertas para Feedback Detalhado:**
   - Perguntas abertas permitem que os usuários expressem livremente suas opiniões e sugestões. Elas são essenciais para coletar insights qualitativos que podem não emergir de perguntas mais direcionadas. Este tipo de feedback é valioso para identificar novas oportunidades de melhoria e inovação.

&emsp;&emsp;Ao estruturar perguntas nessas categorias, o roteiro dos testes de usabilidade ajuda a equipe a coletar dados abrangentes e detalhados. Estes dados não apenas identificam problemas a serem corrigidos, mas também proporcionam uma compreensão profunda das necessidades e expectativas dos usuários, guiando futuras melhorias e desenvolvimentos no aplicativo.

### Tabulação de Testes de Usabilidade
&emsp;&emsp; Os usuários foram convidados a realizar uma série de tarefas específicas no aplicativo, enquanto a equipe de desenvolvimento observava e registrava suas interações, comentários e feedbacks <a href="https://docs.google.com/spreadsheets/d/1wlSXqbKm0uhNWuRMyoE5r9UMI_K35J0-3biwEqkJSsA/edit?usp=sharing">nesta planilha</a>. Com isso, foi possível identificar pontos de atrito, dificuldades e sugestões de melhoria no design e na usabilidade do aplicativo.

&emsp;&emsp; De 36 etapas realizadas, 32 foram concluídas sem nenhuma dificuldade, resultando em uma taxa de sucesso total de 88,89%. As etapas em que usuários apresentaram confusão ou dificuldade estão relacionadas principalmente à disposição dos elementos na tela e/ou à clareza das informações dentro da tela.

**Feedbacks Positivos**
- **Interface Limpa e Organizada:** A maioria dos usuários elogiou a interface limpa e organizada do aplicativo, destacando a clareza e a simplicidade do design.
- **Facilidade de Navegação:** Os usuários acharam a navegação intuitiva e fácil de usar, com botões e menus bem posicionados e identificados.
- **Identidade Visual Atraente:** A identidade visual do aplicativo foi bem recebida, com cores agradáveis, interface limpa e fontes legíveis.

**Feedbacks de Melhoria**
- **Disposição dos Elementos:** Alguns usuários tiveram dificuldade em encontrar elementos específicos, como a parte de avaliação de um projeto, devido à posição muito abaixo na tela.
- **Clareza das Informações:** Alguns usuários sugeriram melhorar a clareza das informações em certas telas,  como a troca do ícone de megafone para uma casa dentro da tela de *Home/Projetos Recomendados* e mudanças do título nessa mesma página, tornando-as mais descritivas e informativas.
- **Facilidade de Acesso:** Alguns usuários sugeriram tornar a opção de criar um projeto mais visível e presente como um componente fixo nas telas, para facilitar o acesso a qualquer momento durante a jornada do usuário.

&emsp;&emsp; Os testes de usabilidade foram fundamentais para identificar pontos de atrito e oportunidades de melhoria no design do aplicativo. Com base nos feedbacks recebidos, é possível saber onde focar para melhorar o design e usabilidade do aplicativo. Os ícones e títulos serão ajustados, a disposição dos elementos será reorganizada e a opção de criar um projeto será um elemento fixo em mais telas.

### Avaliação do Sistema Usabilidade (SUS)
&emsp;&emsp;Após a realização dos testes com 6 usuários, foi possível identificar alguns pontos em relação a usabilidade e possíveis pontos de melhoria no mockup do aplicativo do LegacyLab. Os resultados podem ser vistos <a href="https://docs.google.com/spreadsheets/d/1wlSXqbKm0uhNWuRMyoE5r9UMI_K35J0-3biwEqkJSsA/edit?usp=sharing">neste link</a>. Em relação ao SUS, o procedimento de cálculo e interpretação dos resultados foi realizado conforme descrito abaixo:

**Questões ímpares (1, 3, 5, 7, 9):**
- A pontuação atribuída é subtraída por 1.
- Exemplo: Se a pontuação é 4, o valor convertido é 4 - 1 = 3.

<br>

**Questões pares (2, 4, 6, 8, 10):**
- Subtraia a pontuação de 5.
- Exemplo: Se a pontuação é 3, o valor convertido é 5 - 3 = 2.

<br>

**Soma e Multiplicação para Obter a Pontuação SUS:**
- Some todas as pontuações convertidas para obter um total (Máximo de 40).
- Multiplique o total por 2.5 para escalar a pontuação para uma faixa de 0 a 100.

<br>

**Interpretação dos Resultados do SUS:**

&emsp;&emsp; Os resultados individuais foram tabulados e a média total foi calculada para obter a pontuação média do SUS para o aplicativo. A pontuação média do SUS foi de aproximadamente 96, indicando uma excelente usabilidade do aplicativo, com poucos pontos de atrito ou dificuldade. Os resultados do SUS são um indicativo de que o design do aplicativo atende às expectativas dos usuários e fornece uma experiência satisfatória.

<br>

**Pontuação de Aceitabilidade do SUS:**
<div align="center">
  <sub>Figura 67: Score do SUS</sub><br>
  <img src="./images/tests/sus-score.png" width="100%"><br>
  <sup>Fonte: UX Collective BR</sup>
</div>

<br>

**Resultados Individuais:**

  | Usuário           | Média SUS |
  |-------------------|-----------|
  | Usuário 1         | 100       |
  | Usuário 2         | 87,5      |
  | Usuário 3         | 75        |
  | Usuário 4         | 92,5      |
  | Usuário 5         | 100       |
  | Usuário 6         | 100       |
  |  **Média Total:** | **96,25** |

&emsp;&emsp;Com base nos resultados do teste de usabilidade e na avaliação do SUS, foi possível concluir que o mockup do aplicativo do LegacyLab apresenta uma excelente usabilidade, com uma pontuação média de 96,25. Isso indica que os usuários acharam o aplicativo fácil de usar, intuitivo e eficiente, com poucos pontos de atrito ou dificuldade. Os resultados positivos do teste de usabilidade e do SUS são um indicativo de que o design do aplicativo atende às expectativas dos usuários e fornece uma experiência satisfatória.


## 10.2 Testes de Integração

&emsp;&emsp;Aqui, discutiremos os testes de integração realizados para garantir que os diferentes componentes do sistema funcionem corretamente quando combinados. Esses testes são essenciais para verificar a comunicação e a interoperabilidade entre o frontend e o backend, bem como a integração com serviços de terceiros. Descreveremos os casos de teste, as ferramentas utilizadas e os resultados obtidos.

### Integração Backend com o Banco de Dados

&emsp;&emsp;Nesta documentação, detalharemos o processo de testes de integração realizado entre o frontend, o backend desenvolvido, e as APIs externas. O objetivo é assegurar que todas as partes do sistema funcionem harmoniosamente. Os testes abrangem diversos endpoints e verificam tanto a correção dos dados retornados quanto a integridade das operações de banco de dados.

### Estratégia de Testes

**1. Planejamento e Execução dos Testes**
  - Pré-condições: Configuração de ambiente, incluindo banco de dados e API.
  - Cenários: Testes de cada endpoint definido, verificando resposta da API e consistência de dados no banco.
  - Pós-condições: Validação dos resultados, registros de logs e correção de inconsistências.

**2. Testes de Integração Positivos e Negativos**
  - **Positivos**: Verificam se as funcionalidades estão operando conforme esperado.
  - **Negativos**: Testam condições de erro, como dados inválidos e respostas a entradas inesperadas.

### Testes Realizados

#### 1. Teste para Macrotemas

**Endpoint**: `GET /macrothemes`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com macrotemas pré-carregados.
- **Cenário**: Fazer uma requisição GET e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_data_macrothemes():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_MACROTHEMES, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_macrothemes(db_connection, api_data_macrothemes):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    for item in api_data_macrothemes:
        cursor.execute("SELECT name FROM macrotheme WHERE id = %s", (item['id'],))
        db_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 2. Teste para Projetos de Macrotemas

**Endpoint**: `GET /macrothemes/{id}/projects`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com projetos relacionados a macrotemas.
- **Cenário**: Fazer uma requisição GET para obter projetos de um macrotema específico e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
API_URL_PROJECTS_BY_MACROTHEME = "http://localhost:5220/macrothemes/6/projects"

@pytest.fixture
def api_data_projects_by_macrotheme():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_PROJECTS_BY_MACROTHEME, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_projects_by_macrotheme(db_connection, api_data_projects_by_macrotheme):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    for item in api_data_projects_by_macrotheme:
        cursor.execute("""
            SELECT name, description, short_description, status FROM project WHERE id = %s
        """, (item['id'],))
        db_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"
        assert db_value[1] == item['description'], f"Descrição incorreta para id {item['id']}: esperado {item['description']}, obtido {db_value[1]}"
        assert db_value[2] == item['shortDescription'], f"Descrição curta incorreta para id {item['id']}: esperado {item['shortDescription']}, obtido {db_value[2]}"
        assert db_value[3] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[3]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 3. Teste para Microtemas de Macrotemas

**Endpoint**: `GET /macrothemes/{id}/microthemes`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com microtemas relacionados a macrotemas.
- **Cenário**: Fazer uma requisição GET para obter microtemas de um macrotema específico e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
API_URL_MICROTHEMES_BY_MACROTHEME = "http://localhost:5220/macrothemes/6/microthemes"

@pytest.fixture
def api_data_microthemes_by_macrotheme():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_MICROTHEMES_BY_MACROTHEME, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_microthemes_by_macrotheme(db_connection, api_data_microthemes_by_macrotheme):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    for item in api_data_microthemes_by_macrotheme:
        cursor.execute("SELECT name FROM microtheme WHERE id = %s", (item['id'],))
        db_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 4. Teste para Rating de Projetos

**Endpoint**: `GET /projects/1/users/1/ratings`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com ratings de projetos.
- **Cenário**: Fazer uma requisição GET para obter o rating de um projeto específico por um usuário específico e comparar a resposta

 com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_data_rating():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_RATING, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_rating(db_connection, api_data_rating):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    item = api_data_rating
    cursor.execute("SELECT rating FROM interest WHERE id = %s", (item['id'],))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
    assert db_value[0] == item['rating'], f"Rating incorreto para id {item['id']}: esperado {item['rating']}, obtido {db_value[0]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 5. Teste para Recomendações de Projetos

**Endpoint**: `GET /projects/users/1/recommendations`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com recomendações de projetos.
- **Cenário**: Fazer uma requisição GET para obter recomendações de projetos para um usuário específico e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
API_URL_RECOMMENDATIONS = "http://localhost:5220/projects/users/1/recommendations"

@pytest.fixture
def api_data_recommendations():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_RECOMMENDATIONS, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_recommendations(db_connection, api_data_recommendations):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    for item in api_data_recommendations:
        cursor.execute("""
            SELECT name, description, short_description, status FROM project WHERE id = %s
        """, (item['id'],))
        db_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"
        assert db_value[1] == item['description'], f"Descrição incorreta para id {item['id']}: esperado {item['description']}, obtido {db_value[1]}"
        assert db_value[2] == item['shortDescription'], f"Descrição curta incorreta para id {item['id']}: esperado {item['shortDescription']}, obtido {db_value[2]}"
        assert db_value[3] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[3]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 6. Teste para Projetos por ID

**Endpoint**: `GET /projects/3`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com projetos.
- **Cenário**: Fazer uma requisição GET para obter um projeto específico e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
API_URL_PROJECT = "http://localhost:5220/projects/3"

@pytest.fixture
def api_data_project():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_PROJECT, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_project(db_connection, api_data_project):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    item = api_data_project
    cursor.execute("""
        SELECT name, description, short_description, status FROM project WHERE id = %s
    """, (item['id'],))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
    assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"
    assert db_value[1] == item['description'], f"Descrição incorreta para id {item['id']}: esperado {item['description']}, obtido {db_value[1]}"
    assert db_value[2] == item['shortDescription'], f"Descrição curta incorreta para id {item['id']}: esperado {item['shortDescription']}, obtido {db_value[2]}"
    assert db_value[3] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[3]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 7. Teste para Sinergias de Projetos

**Endpoint**: `GET /projects/1/synergies`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com sinergias de projetos.
- **Cenário**: Fazer uma requisição GET para obter sinergias de um projeto específico e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
API_URL_SYNERGIES = "http://localhost:5220/projects/1/synergies"

@pytest.fixture
def api_data_synergies():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_SYNERGIES, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_synergies(db_connection, api_data_synergies):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    for item in api_data_synergies:
        cursor.execute("""
            SELECT type, status FROM synergy WHERE id = %s
        """, (item['id'],))
        db

_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['type'], f"Tipo incorreto para id {item['id']}: esperado {item['type']}, obtido {db_value[0]}"
        assert db_value[1] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[1]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 8. Teste para Projetos por Usuário

**Endpoint**: `GET /projects/users/1`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com projetos atribuídos a um usuário.
- **Cenário**: Fazer uma requisição GET para obter projetos atribuídos a um usuário específico e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
API_URL_PROJECTS_BY_USER = "http://localhost:5220/projects/users/1"

@pytest.fixture
def api_data_projects_by_user():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_PROJECTS_BY_USER, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_projects_by_user(db_connection, api_data_projects_by_user):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    for item in api_data_projects_by_user:
        cursor.execute("""
            SELECT name, description, short_description, status FROM project WHERE id = %s
        """, (item['id'],))
        db_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
        assert db_value[0] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[0]}"
        assert db_value[1] == item['description'], f"Descrição incorreta para id {item['id']}: esperado {item['description']}, obtido {db_value[1]}"
        assert db_value[2] == item['shortDescription'], f"Descrição curta incorreta para id {item['id']}: esperado {item['shortDescription']}, obtido {db_value[2]}"
        assert db_value[3] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[3]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 9. Teste para Sinergia por ID

**Endpoint**: `GET /synergies/59`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com sinergias.
- **Cenário**: Fazer uma requisição GET para obter uma sinergia específica e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_data_synergy():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_SYNERGY, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_synergy(db_connection, api_data_synergy):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    item = api_data_synergy
    cursor.execute("""
        SELECT 
            s.type, s.status, 
            sp.id AS sourceProjectId, sp.name AS sourceProjectName, su.name AS sourceUserName, su.enterprise AS sourceUserEnterprise, smi.name AS sourceMicrotheme, sma.name AS sourceMacrotheme,
            tp.id AS targetProjectId, tp.name AS targetProjectName, tu.name AS targetUserName, tu.enterprise AS targetUserEnterprise, tmi.name AS targetMicrotheme, tma.name AS targetMacrotheme
        FROM 
            synergy s
        JOIN 
            project sp ON s.source_project = sp.id
        JOIN 
            "user" su ON sp.id_user = su.id
        JOIN 
            microtheme smi ON sp.id_microtheme = smi.id
        JOIN 
            macrotheme sma ON smi.id_macrotheme = sma.id
        JOIN 
            project tp ON s.target_project = tp.id
        JOIN 
            "user" tu ON tp.id_user = tu.id
        JOIN 
            microtheme tmi ON tp.id_microtheme = tmi.id
        JOIN 
            macrotheme tma ON tmi.id_macrotheme = tma.id
        WHERE 
            s.id = %s
    """, (item['id'],))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
    assert db_value[0] == item['type'], f"Tipo incorreto para id {item['id']}: esperado {item['type']}, obtido {db_value[0]}"
    assert db_value[1] == item['status'], f"Status incorreto para id {item['id']}: esperado {item['status']}, obtido {db_value[1]}"
    assert db_value[2] == item['sourceProjectId'], f"sourceProjectId incorreto para id {item['id']}: esperado {item['sourceProjectId']}, obtido {db_value[2]}"
    assert db_value[3] == item['sourceProjectName'], f"sourceProjectName incorreto para id {item['id']}: esperado {item['sourceProjectName']}, obtido {db_value[3]}"
    assert db_value[4] == item['sourceUserName'], f"sourceUserName incorreto para id {item['id']}: esperado {item['sourceUserName']}, obtido {db_value[4]}"
    assert db_value[5] == item['sourceUserEnterprise'], f"sourceUserEnterprise incorreto para id {item['id']}: esperado {item['sourceUserEnterprise']}, obtido {db_value[5]}"
    assert db_value[6] == item['sourceMicrotheme'], f"sourceMicrotheme incorreto para id {item['id']}: esperado {item['sourceMicrotheme']}, obtido {db_value[6]}"
    assert db_value[7] == item['sourceMacrotheme'], f"sourceMacrotheme incorreto para id {item['id']}: esperado {item['sourceMacrotheme']}, obtido {db_value[7]}"
    assert db_value[8] == item['targetProjectId'], f"targetProjectId incorreto para id {item['id']}: esperado {item['targetProjectId']}, obtido {db_value[8]}"
    assert db_value[9] == item['targetProjectName'], f"targetProjectName incorreto para id {item['id']}: esperado {item['targetProjectName']}, obtido {db_value[9]}"
    assert db_value[

10] == item['targetUserName'], f"targetUserName incorreto para id {item['id']}: esperado {item['targetUserName']}, obtido {db_value[10]}"
    assert db_value[11] == item['targetUserEnterprise'], f"targetUserEnterprise incorreto para id {item['id']}: esperado {item['targetUserEnterprise']}, obtido {db_value[11]}"
    assert db_value[12] == item['targetMicrotheme'], f"targetMicrotheme incorreto para id {item['id']}: esperado {item['targetMicrotheme']}, obtido {db_value[12]}"
    assert db_value[13] == item['targetMacrotheme'], f"targetMacrotheme incorreto para id {item['id']}: esperado {item['targetMacrotheme']}, obtido {db_value[13]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 10. Teste para Criação de Sinergia

**Endpoint**: `POST /synergies`

**Plano de Testes**:
- **Pré-condições**: Banco de dados configurado para aceitar novas sinergias.
- **Cenário**: Fazer uma requisição POST para criar uma nova sinergia e verificar se foi inserida corretamente no banco.
- **Pós-condições**: Confirmação de que a sinergia foi criada com os dados corretos.

**Código do Teste**:
```python
API_URL_CREATE_SYNERGY = "http://localhost:5220/synergies"

@pytest.fixture
def api_create_synergy():
    """
    Fixture que faz uma requisição POST à API para criar uma sinergia.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "sourceProject": 4,
        "targetProject": 5,
        "type": "string",
        "status": "string"
    }
    response = requests.post(API_URL_CREATE_SYNERGY, headers=headers, json=data)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_create_synergy(db_connection, api_create_synergy):
    """
    Teste de integração que valida se a sinergia foi criada corretamente no banco de dados.
    """
    cursor = db_connection.cursor()

    synergy_id = api_create_synergy
    cursor.execute("SELECT type, status FROM synergy WHERE id = %s", (synergy_id,))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Sinergia com id {synergy_id} não encontrada no banco de dados."
    assert db_value[0] == "string", f"Tipo incorreto para id {synergy_id}: esperado 'string', obtido {db_value[0]}"
    assert db_value[1] == "string", f"Status incorreto para id {synergy_id}: esperado 'string', obtido {db_value[1]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 11. Teste para Criação de Atualização de Sinergia

**Endpoint**: `POST /synergies/:id/updates`

**Plano de Testes**:
- **Pré-condições**: Banco de dados configurado para aceitar novas atualizações de sinergias.
- **Cenário**: Fazer uma requisição POST para criar uma nova atualização de sinergia e verificar se foi inserida corretamente no banco.
- **Pós-condições**: Confirmação de que a atualização foi criada com os dados corretos.

**Código do Teste**:
```python
API_URL_CREATE_SYNERGY_UPDATE = "http://localhost:5220/synergies/59/updates"

@pytest.fixture
def api_create_synergy_update():
    """
    Fixture que faz uma requisição POST à API para criar uma atualização de sinergia.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "title": "string",
        "description": "string"
    }
    response = requests.post(API_URL_CREATE_SYNERGY_UPDATE, headers=headers, json=data)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_create_synergy_update(db_connection, api_create_synergy_update):
    """
    Teste de integração que valida se a atualização de sinergia foi criada corretamente no banco de dados.
    """
    cursor = db_connection.cursor()

    update_id = api_create_synergy_update
    cursor.execute("SELECT title, description FROM update WHERE id = %s", (update_id,))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Atualização de sinergia com id {update_id} não encontrada no banco de dados."
    assert db_value[0] == "string", f"Título incorreto para id {update_id}: esperado 'string', obtido {db_value[0]}"
    assert db_value[1] == "string", f"Descrição incorreta para id {update_id}: esperado 'string', obtido {db_value[1]}"

    cursor.close()
```

**Evidências de Execução**:
- Relatórios de execução e logs da aplicação confirmando a correspondência dos dados.

#### 12. Teste para Dados de Usuário

**Endpoint**: `GET /users/1`

**Plano de Testes**:
- **Pré-condições**: Banco de dados com dados de usuários.
- **Cenário**: Fazer uma requisição GET para obter dados de um usuário específico e comparar a resposta com os dados do banco.
- **Pós-condições**: Confirmação de que os dados da API correspondem aos do banco.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_data_user():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_USER, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_user(db_connection, api_data_user):
    """
    Teste de integração que valida se os dados da API estão presentes e corretos no banco de dados.
    """
    cursor = db_connection.cursor()

    item = api_data_user
    cursor.execute("""
        SELECT 
            id, name, enterprise, position, email
        FROM 
            "user"
        WHERE 
            id = %s
    """, (item['id'],))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Item com id {item['id']} não encontrado no banco de dados."
    assert db_value[1] == item['name'], f"Nome incorreto para id {item['id']}: esperado {item['name']}, obtido {db_value[1]}"
    assert db_value[2] == item['enterprise'], f"Enterprise incorreto para id {item['id']}: esperado {item['enterprise']}, obtido {db_value[2]}"
    assert db_value[3] == item['position'], f"Position incorreto para id {item['id']}: esperado {item['position']}, obtido {db_value[3]}"
    assert db_value[4] == item['email'], f"Email incorreto para id {item['id']}: esperado {item['email']}, obtido {db_value[4]}"

    cursor.close()
```

#### 13. Teste para Criação de Projeto

**Endpoint**: `POST /projects`

**Plano de Testes**:
- **Pré-condições**: A API deve estar em execução. O banco de dados deve estar acessível. Um token de autenticação válido deve estar disponível.
- **Cenário**: Fazer uma requisição POST para criar um novo projeto e verificar se ele foi criado corretamente no banco de dados.
- **Pós-condições**: O projeto deve ser criado corretamente no banco de dados.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

API_URL_CREATE_PROJECT = "http://localhost:5220/projects"
BEARER_TOKEN = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNzE3Njk0ODUyLCJleHAiOjE3MTgyOTk2NTIsImlhdCI6MTcxNzY5NDg1Mn0.z9_wIyR5n2Yfb3Kae-B1gUWXOYbXkDFfA5iuu5EZziA"
DB_HOST = "silly.db.elephantsql.com"
DB_PORT = "5432"
DB_NAME = "fybsgwhw"
DB_USER = "fybsgwhw"
DB_PASSWORD = "8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA"

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_create_project():
    """
    Fixture que faz uma requisição POST à API para criar um projeto.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "name": "string",
        "description": "string",
        "shortDescription": "string",
        "status": "string",
        "userId": 0,
        "microthemeId": 0
    }
    response = requests.post(API_URL_CREATE_PROJECT, headers=headers, json=data)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_create_project(db_connection, api_create_project):
    """
    Teste de integração que valida se o projeto foi criado corretamente no banco de dados.
    """
    cursor = db_connection.cursor()

    project_id = api_create_project
    cursor.execute("SELECT name, description, short_description, status FROM project WHERE id = %s", (project_id,))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Projeto com id {project_id} não encontrado no banco de dados."
    assert db_value[0] == "string", f"Nome incorreto para id {project_id}: esperado 'string', obtido {db_value[0]}"
    assert db_value[1] == "string", f"Descrição incorreta para id {project_id}: esperado 'string', obtido {db_value[1]}"
    assert db_value[2] == "string", f"Descrição curta incorreta para id {project_id}: esperado 'string', obtido {db_value[2]}"
    assert db_value[3] == "string", f"Status incorreto para id {project_id}: esperado 'string', obtido {db_value[3]}"

    cursor.close()
```

#### 14. Teste para Gerar Descrição do Projeto

**Endpoint**: `POST /projects/generate-description`

**Plano de Testes**:
- **Pré-condições**: A API deve estar em execução. O banco de dados deve estar acessível. Um token de autenticação válido deve estar disponível.
- **Cenário**: Fazer uma requisição POST para gerar uma descrição de projeto e verificar se a descrição foi gerada corretamente.
- **Pós-condições**: A descrição do projeto deve ser gerada corretamente no banco de dados.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

API_URL_GENERATE_DESCRIPTION = "http://localhost:5220/projects/generate-description"
BEARER_TOKEN = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNzE3Njk0ODUyLCJleHAiOjE3MTgyOTk2NTIsImlhdCI6MTcxNzY5NDg1Mn0.z9_wIyR5n2Yfb3Kae-B1gUWXOYbXkDFfA5iuu5EZziA"
DB_HOST = "silly.db.elephantsql.com"
DB_PORT = "5432"
DB_NAME = "fybsgwhw"
DB_USER = "fybsgwhw"
DB_PASSWORD = "8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA"

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_generate_description():
    """
    Fixture que faz uma requisição POST à API para gerar uma descrição de projeto.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "projectName": "string",
        "projectDetails": "string"
    }
    response = requests.post(API_URL_GENERATE_DESCRIPTION, headers=headers, json=data)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_generate_description(db_connection, api_generate_description):
    """
    Teste de integração que valida se a descrição do projeto foi gerada corretamente no banco de dados.
    """
    cursor = db_connection.cursor()

    description_id = api_generate_description
    cursor.execute("SELECT description FROM project WHERE id = %s", (description_id,))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Descrição com id {description_id} não encontrada no banco de dados."
    assert db_value[0] == "string", f"Descrição incorreta para id {description_id}: esperado 'string', obtido {db_value[0]}"

    cursor.close()
```

#### 15. Teste para Adicionar Avaliação a um Projeto

**Endpoint**: `POST /projects/:id/ratings`

**Plano de Testes**:
- **Pré-condições**: A API deve estar em execução. O banco de dados deve estar acessível. Um token de autenticação válido deve estar disponível.
- **Cenário**: Fazer uma requisição POST para adicionar uma avaliação a um projeto e verificar se a avaliação foi adicionada corretamente.
- **Pós-condições**: A avaliação deve ser adicionada corretamente ao banco de dados.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

API_URL_POST_RATING = "http://localhost:5220/projects/1/ratings"
BEARER_TOKEN = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNzE3Njk0ODUyLCJleHAiOjE3MTgyOTk2NTIsImlhdCI6MTcxNzY5NDg1Mn0.z9_wIyR5n2Yfb3Kae-B1gUWXOYbXkDFfA5iuu5EZziA"
DB_HOST = "silly.db.elephantsql.com"
DB_PORT = "5432"
DB_NAME = "fybsgwhw"
DB_USER = "fybsgwhw"
DB_PASSWORD = "8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA"

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_post_rating():
    """
    Fixture que faz uma requisição POST à API para adicionar uma avaliação a um projeto.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    data = {
        "rating": 0,
        "userId": 0
    }
    response = requests.post(API_URL_POST_RATING, headers=headers, json=data)
    response

.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_post_rating(db_connection, api_post_rating):
    """
    Teste de integração que valida se a avaliação foi adicionada corretamente no banco de dados.
    """
    cursor = db_connection.cursor()

    rating_id = api_post_rating
    cursor.execute("SELECT rating FROM interest WHERE id = %s", (rating_id,))
    db_value = cursor.fetchone()

    # Verifica se o valor no banco de dados corresponde ao valor da API
    assert db_value is not None, f"Avaliação com id {rating_id} não encontrada no banco de dados."
    assert db_value[0] == 0, f"Rating incorreto para id {rating_id}: esperado 0, obtido {db_value[0]}"

    cursor.close()
```

#### 16. Teste para Atualizações de Sinergia

**Endpoint**: `GET /synergies/59/updates`

**Plano de Testes**:
- **Pré-condições**: A API deve estar em execução. O banco de dados deve estar acessível. Um token de autenticação válido deve estar disponível.
- **Cenário**: Fazer uma requisição GET para obter as atualizações de sinergia e verificar se os dados estão corretos.
- **Pós-condições**: Os dados da atualização de sinergia devem corresponder ao banco de dados.

**Código do Teste**:
```python
import requests
import psycopg2
import pytest

API_URL_SYNERGY_UPDATES = "http://localhost:5220/synergies/59/updates"
BEARER_TOKEN = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmJmIjoxNzE3Njk0ODUyLCJleHAiOjE3MTgyOTk2NTIsImlhdCI6MTcxNzY5NDg1Mn0.z9_wIyR5n2Yfb3Kae-B1gUWXOYbXkDFfA5iuu5EZziA"
DB_HOST = "silly.db.elephantsql.com"
DB_PORT = "5432"
DB_NAME = "fybsgwhw"
DB_USER = "fybsgwhw"
DB_PASSWORD = "8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA"

@pytest.fixture(scope="module")
def db_connection():
    """
    Fixture que estabelece uma conexão com o banco de dados antes dos testes e fecha após os testes.
    """
    conn = psycopg2.connect(
        host=DB_HOST,
        port=DB_PORT,
        dbname=DB_NAME,
        user=DB_USER,
        password=DB_PASSWORD
    )
    yield conn
    conn.close()

@pytest.fixture
def api_data_synergy_updates():
    """
    Fixture que faz uma requisição GET à API e retorna os dados.
    """
    headers = {
        "Authorization": BEARER_TOKEN,
        "Content-Type": "application/json"
    }
    response = requests.get(API_URL_SYNERGY_UPDATES, headers=headers)
    response.raise_for_status()  # Lança um erro se a requisição falhar
    return response.json()

def test_api_data_in_db_synergy_updates(db_connection, api_data_synergy_updates):
    """
    Teste de integração que valida se as atualizações de sinergia da API estão presentes e corretas no banco de dados.
    """
    cursor = db_connection.cursor()

    for item in api_data_synergy_updates:
        cursor.execute("SELECT title, description, datetime FROM update WHERE id = %s", (item['id'],))
        db_value = cursor.fetchone()

        # Verifica se o valor no banco de dados corresponde ao valor da API
        assert db_value is not None, f"Atualização de sinergia com id {item['id']} não encontrada no banco de dados."
        assert db_value[0] == item['title'], f"Título incorreto para id {item['id']}: esperado {item['title']}, obtido {db_value[0]}" 
        assert db_value[1] == item['description'], f"Descrição incorreta para id {item['id']}: esperado {item['description']}, obtido {db_value[1]}"
        assert db_value[2].isoformat() == item['datetime'], f"Data incorreta para id {item['id']}: esperado {item['datetime']}, obtido {db_value[2].isoformat()}"

    cursor.close()
```

### Integração do Frontend com Backend

&emsp;&emsp;A integração do frontend com o backend é uma etapa crucial no desenvolvimento do aplicativo, garantindo que os componentes funcionem de forma harmoniosa e eficiente. Neste contexto, a integração do frontend do LegacyLab com o backend foi realizada para garantir que as funcionalidades do aplicativo sejam acessíveis e operacionais, permitindo que os usuários interajam com o sistema de forma eficaz.

&emsp;&emsp;É possível verificar a integração e o funcionamento do sistema completo a partir do vídeo de demonstração do aplicativo, que mostra as principais funcionalidades e interações do usuário com o aplicativo e verifica o banco de dados para garantir que a integracão entre o frontend e o backend esteja funcionando corretamente. O vídeo de demonstração pode ser acessado [aqui](https://drive.google.com/file/d/149zSiENcW1vTHtkBVOSsztJwC-XmnbZv/view?usp=sharing).


## 10.3 Testes dos Serviços

&emsp;&emsp;Nesta parte, focaremos nos testes dos serviços backend, incluindo testes unitários. Explicaremos como cada serviço foi testado individualmente para garantir seu funcionamento correto e sua capacidade de lidar com diferentes cargas de trabalho. Detalharemos as metodologias de teste aplicadas e os resultados alcançados.

### Documentação dos Testes Unitários para os Controllers

&emsp;&emsp;Os testes de unitários são essenciais para garantir que os controllers do aplicativo funcionem conforme o esperado e atendam aos requisitos de negócio. Eles verificam se os métodos dos controllers respondem corretamente às requisições HTTP, processam os dados adequadamente e retornam as respostas esperadas. Os testes de unitários ajudam a identificar possíveis erros, bugs e falhas de lógica no código, garantindo a qualidade e a confiabilidade do software. A seguir, está a documentação dos testes unitários para os controllers `MacroThemeController`, `UserController` e `ProjectController`.

&emsp;&emsp;O controller é um componente central na arquitetura de uma aplicação, desempenhando um papel fundamental na comunicação entre o usuário e o sistema. Sua principal responsabilidade é receber as requisições dos usuários, processar os dados conforme a lógica de negócios e retornar as respostas adequadas.

&emsp;&emsp;Quando uma requisição é recebida, o controller atua como intermediário, invocando os métodos apropriados do modelo para manipulação dos dados e lógica da aplicação. Após processar a requisição, o controller formata a resposta de acordo com a necessidade, frequentemente encapsulando os resultados em uma resposta HTTP adequada. Esta resposta pode incluir dados, mensagens de sucesso ou erro, dependendo do resultado do processamento.

&emsp;&emsp;O uso de testes, como os de desenvolvimento orientado a testes (TDD), assegura que o controller funcione conforme esperado. Um teste típico verifica se o controller responde corretamente a diferentes cenários. Por exemplo, ele verifica se, ao não encontrar dados correspondentes a uma solicitação, o controller retorna uma resposta adequada, como uma lista vazia ou uma mensagem de erro específica. Assim, o teste garante que o comportamento do controller é robusto e atende às especificações da aplicação, contribuindo para a confiabilidade e a qualidade do software.

#### MacroThemeControllerTests

**Objetivo:** Verificar se os endpoints do `MacroThemeController` funcionam corretamente e interagem de forma adequada com o repositório.

1. **GetAllMacroThemes_ReturnsListOfMacroThemes_WhenMacroThemesExist**
    - **Descrição:** Verifica se o endpoint `GET /macrothemes` retorna uma lista de macrotemas quando eles existem no banco de dados.
    - **Arranjo:** Configura o repositório mock para retornar uma lista de `MacroThemeDTO`.
    - **Ação:** Chama o método `GetAllMacroThemes` do controller.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se a lista retornada contém os macrotemas esperados.

2. **GetAllMacroThemes_ReturnsEmptyList_WhenNoMacroThemesExist**
    - **Descrição:** Verifica se o endpoint `GET /macrothemes` retorna uma lista vazia quando não existem macrotemas no banco de dados.
    - **Arranjo:** Configura o repositório mock para retornar uma lista vazia.
    - **Ação:** Chama o método `GetAllMacroThemes` do controller.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se a lista retornada está vazia.

3. **GetProjectsByMacroThemeId_ReturnsListOfProjects_WhenProjectsExist**
    - **Descrição:** Verifica se o endpoint `GET /macrothemes/{id}/projects` retorna uma lista de projetos associados a um macrotema específico.
    - **Arranjo:** Configura o repositório mock para retornar uma lista de `ProjectDTO`.
    - **Ação:** Chama o método `GetProjectsByMacroThemeId` com um ID de macrotema válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se a lista retornada contém os projetos esperados.

4. **GetProjectsByMacroThemeId_ReturnsEmptyList_WhenNoProjectsExist**
    - **Descrição:** Verifica se o endpoint `GET /macrothemes/{id}/projects` retorna uma lista vazia quando não existem projetos associados ao macrotema.
    - **Arranjo:** Configura o repositório mock para retornar uma lista vazia.
    - **Ação:** Chama o método `GetProjectsByMacroThemeId` com um ID de macrotema válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se a lista retornada está vazia.

#### UserControllerTests

**Objetivo:** Verificar se os endpoints do `UserController` funcionam corretamente e interagem de forma adequada com o repositório.

1. **GetUserById_ReturnsOkResult_WhenUserExists**
    - **Descrição:** Verifica se o endpoint `GET /users/{id}` retorna as informações de um usuário existente.
    - **Arranjo:** Configura o repositório mock para retornar um `UserDTO` válido.
    - **Ação:** Chama o método `GetUserById` com um ID de usuário válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se o usuário retornado corresponde ao esperado.

2. **GetUserById_ReturnsNotFoundResult_WhenUserDoesNotExist**
    - **Descrição:** Verifica se o endpoint `GET /users/{id}` retorna um `NotFoundResult` quando o usuário não existe.
    - **Arranjo:** Configura o repositório mock para retornar `null`.
    - **Ação:** Chama o método `GetUserById` com um ID de usuário inválido.
    - **Asserção:** Verifica se o resultado é um `NotFoundResult`.

3. **GetUserById_WhenUserExists_ReturnsOkResult**
    - **Descrição:** Verifica se o endpoint `GET /users/{id}` retorna as informações corretas de um usuário existente (teste repetido, pode ser combinado com o primeiro).
    - **Arranjo:** Configura o repositório mock para retornar um `UserDTO` válido.
    - **Ação:** Chama o método `GetUserById` com um ID de usuário válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se o usuário retornado corresponde ao esperado.

4. **GetUserById_WhenUserDoesNotExist_ReturnsNotFoundResult**
    - **Descrição:** Verifica se o endpoint `GET /users/{id}` retorna um `NotFoundResult` quando o usuário não existe (teste repetido, pode ser combinado com o segundo).
    - **Arranjo:** Configura o repositório mock para retornar `null`.
    - **Ação:** Chama o método `GetUserById` com um ID de usuário inválido.
    - **Asserção:** Verifica se o resultado é um `NotFoundResult`.

#### ProjectControllerTests

**Objetivo:** Verificar se os endpoints do `ProjectController` funcionam corretamente e interagem de forma adequada com o repositório.

1. **CreateProject_WhenProjectCreated_ReturnsOk**
    - **Descrição:** Verifica se o endpoint `POST /projects` cria um novo projeto e retorna um `OkObjectResult` com o ID do projeto criado.
    - **Arranjo:** Configura o repositório mock para retornar um ID válido de projeto.
    - **Ação:** Chama o método `CreateProject` com um `ProjectModel` válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se o ID retornado corresponde ao esperado.

2. **CreateProject_ReturnsBadRequest_WhenProjectIdIsNull**
    - **Descrição:** Verifica se o endpoint `POST /projects` retorna um `BadRequestResult` quando a criação do projeto falha.
    - **Arranjo:** Configura o repositório mock para retornar `null`.
    - **Ação:** Chama o método `CreateProject` com um `ProjectModel` válido.
    - **Asserção:** Verifica se o resultado é um `BadRequestResult`.

3. **CreateProject_ReturnsOk_WhenProjectIdIsNotNull**
    - **Descrição:** Verifica se o endpoint `POST /projects` retorna um `OkObjectResult` com o ID do projeto criado quando a criação é bem-sucedida.
    - **Arranjo:** Configura o repositório mock para retornar um ID válido de projeto.
    - **Ação:** Chama o método `CreateProject` com um `ProjectModel` válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se o ID retornado corresponde ao esperado.

4. **GetProject_IfProjectExists_ReturnsProject**
    - **Descrição:** Verifica se o endpoint `GET /projects/{id}` retorna as informações de um projeto existente.
    - **Arranjo:** Configura o repositório mock para retornar um `ProjectDTO` válido.
    - **Ação:** Chama o método `GetProject` com um ID de projeto válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se o projeto retornado corresponde ao esperado.

5. **GetProject_IfProjectDoesNotExist_ReturnsNotFound**
    - **Descrição:** Verifica se o endpoint `GET /projects/{id}` retorna um `NotFoundResult` quando o projeto não existe.
    - **Arranjo:** Configura o repositório mock para retornar `null`.
    - **Ação:** Chama o método `GetProject` com um ID de projeto inválido.
    - **Asserção:** Verifica se o resultado é um `NotFoundResult`.

6. **GetSynergies_WhenProjectIdValid_ReturnsSynergies**
    - **Descrição:** Verifica se o endpoint `GET /projects/{id}/synergies` retorna uma lista de sinergias associadas ao projeto.
    - **Arranjo:** Configura o repositório mock para retornar uma lista de `SynergyDTO`.
    - **Ação:** Chama o método `GetSynergies` com um ID de projeto válido.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se a lista de sinergias retornada corresponde ao esperado.

7. **UpdateProject_WhenUpdateValid_ReturnsProjectId**
    - **Descrição:** Verifica se o endpoint `PUT /projects/{id}` atualiza um projeto existente e retorna um `OkObjectResult` com o ID do projeto atualizado.
    - **Arranjo:** Configura o repositório mock para retornar um `ProjectDTO` atualizado.
    - **Ação:** Chama o método `UpdateProject` com um ID de projeto válido e um `ProjectModel` atualizado.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se o projeto atualizado corresponde ao esperado.

8. **UpdateProject_WhenProjectDoesNotExist_ReturnsBadRequest**
    - **Descrição:** Verifica se o endpoint `PUT /projects/{id}` retorna um `BadRequestObjectResult` quando o projeto não existe.
    - **Arranjo:** Configura o repositório mock para retornar `false` ao verificar a existência do projeto.
    - **Ação:** Chama o método `UpdateProject` com um ID de projeto inválido e um `ProjectModel` atualizado.
    - **Asserção:** Verifica se o resultado é um `BadRequestObjectResult`.

9. **AddRatingToProject_ReturnsOk_WhenRatingIsCreated**
    - **Descrição:** Verifica se o endpoint `POST /projects/{id}/ratings` adiciona uma nova avaliação a um projeto e retorna um `OkObjectResult` com o ID da avaliação criada.
    - **Arranjo:** Configura o repositório mock para retornar um ID válido de avaliação.
    - **Ação:** Chama o método `AddRatingToProject` com um ID de projeto válido e um `RatingModel`.
    - **Asserção:** Verifica se o resultado é um `OkObjectResult` e se o ID da avaliação retornada corresponde ao esperado.

10. **AddRatingToProject_ReturnsBadRequest_WhenRatingCreationFails**
    - **Descrição:** Verifica se o endpoint `POST /projects/{id}/ratings` retorna um `BadRequestObjectResult` quando a criação da avaliação falha.
    - **Arranjo:** Configura o repositório mock para retornar `null`.
    - **Ação:** Chama o método `AddRatingToProject` com um ID de projeto válido e um `RatingModel`.
    - **Asserção:** Verifica se o resultado é um `BadRequestObjectResult`.

11. **DeleteProject_WhenProjectExists_ReturnsOk**
    - **Descrição:** Verifica se o endpoint `DELETE /projects/{id}` deleta um projeto existente e retorna um `OkResult`.
    - **Arranjo:** Configura o repositório mock para retornar `true` ao verificar a existência do projeto.
    - **Ação:** Chama o método `DeleteProject` com um ID de projeto válido.
    - **Asserção:** Verifica se o resultado é um `OkResult`.

12. **DeleteProject_WhenProjectDoesNotExist_ReturnsBadRequest**
    - **Descrição:** Verifica se o endpoint `DELETE /projects/{id}` retorna um `BadRequestObjectResult` quando o projeto não existe.
    - **Arranjo:** Configura o repositório mock para retornar `false` ao tentar deletar o projeto.
    - **Ação:** Chama o método `DeleteProject` com um ID de projeto inválido.
    - **Asserção:** Verifica se o resultado é um `BadRequestObjectResult`.

&emsp;&emsp;Esses testes garantem que os endpoints dos controllers estão funcionando conforme esperado e que a interação com os repositórios é adequada. Eles ajudam a identificar problemas na lógica de controle e na interação com a camada de persistência de dados.

### Documentação dos Testes Unitários para os Repositories

&emsp;&emsp;Os testes unitários são fundamentais para validar a funcionalidade de métodos individuais em repositórios, garantindo que eles se comportem conforme esperado. Abaixo está a documentação detalhada dos testes unitários para os repositórios `MacroThemeRepository`, `ProjectRepository` e `UserRepository`.

&emsp;&emsp;O repository é uma parte importante da arquitetura de software, responsável por abstrair o acesso aos dados da aplicação. Ele atua como uma camada intermédia entre a lógica da aplicação e a fonte de dados, como um banco de dados ou um serviço externo. O repository encapsula as operações de consulta, inserção, atualização e exclusão de dados, fornecendo uma interface simplificada para a manipulação dos dados da aplicação.

&emsp;&emsp;Dentro da arquitetura MVC (Model-View-Controller), o repository é responsável por realizar operações de persistência de dados, como salvar, recuperar, atualizar e excluir registros do banco de dados. Ele permite que o controller e outros componentes da aplicação interajam com os dados de forma independente da implementação específica do banco de dados, promovendo a modularidade e a manutenibilidade do código.

&emsp;&emsp;Os testes para o repository geralmente verificam se as operações de persistência de dados estão funcionando corretamente, garantindo que os dados sejam salvos e recuperados de acordo com as expectativas da aplicação.

#### MacroThemeRepositoryTests

**Objetivo:** Verificar se os métodos do `MacroThemeRepository` funcionam corretamente e retornam os resultados esperados.

1. **GetAllMacroThemes_ReturnsListOfMacroThemes_WhenMacroThemesExist**
    - **Descrição:** Verifica se o método `GetAllMacroThemes` retorna uma lista de macrotemas quando eles existem no banco de dados.
    - **Arranjo:** Configura o mock do banco de dados para retornar uma lista de `MacroThemeDTO`.
    - **Ação:** Chama o método `GetAllMacroThemes`.
    - **Asserção:** Verifica se a lista retornada é igual à lista esperada.

2. **GetProjectsByMacroThemeId_ReturnsListOfProjects_WhenProjectsExist**
    - **Descrição:** Verifica se o método `GetProjectsByMacroThemeId` retorna uma lista de projetos associados a um macrotema específico.
    - **Arranjo:** Configura o mock do banco de dados para retornar uma lista de `ProjectDTO`.
    - **Ação:** Chama o método `GetProjectsByMacroThemeId` com um ID de macrotema válido.
    - **Asserção:** Verifica se a lista retornada é igual à lista esperada.

3. **GetProjectsByMacroThemeId_ReturnsEmptyList_WhenNoProjectsExist**
    - **Descrição:** Verifica se o método `GetProjectsByMacroThemeId` retorna uma lista vazia quando não existem projetos associados ao macrotema.
    - **Arranjo:** Configura o mock do banco de dados para retornar uma lista vazia.
    - **Ação:** Chama o método `GetProjectsByMacroThemeId` com um ID de macrotema válido.
    - **Asserção:** Verifica se a lista retornada está vazia.

#### ProjectRepositoryTests

**Objetivo:** Verificar se os métodos do `ProjectRepository` funcionam corretamente e retornam os resultados esperados.

1. **GetProjectById_ReturnsProject_WhenProjectExists**
    - **Descrição:** Verifica se o método `GetProjectById` retorna um projeto existente.
    - **Arranjo:** Configura o mock do banco de dados para retornar um `ProjectDTO`.
    - **Ação:** Chama o método `GetProjectById` com um ID de projeto válido.
    - **Asserção:** Verifica se o projeto retornado é igual ao esperado.

2. **GetProjectById_ReturnsNull_WhenProjectDoesNotExist**
    - **Descrição:** Verifica se o método `GetProjectById` retorna `null` quando o projeto não existe.
    - **Arranjo:** Configura o mock do banco de dados para retornar `null`.
    - **Ação:** Chama o método `GetProjectById` com um ID de projeto inválido.
    - **Asserção:** Verifica se o resultado é `null`.

3. **CreateProject_ReturnsProjectId_WhenProjectIsCreated**
    - **Descrição:** Verifica se o método `CreateProject` retorna o ID do projeto criado.
    - **Arranjo:** Configura o mock do banco de dados para retornar um ID válido de projeto.
    - **Ação:** Chama o método `CreateProject` com um `ProjectModel` válido.
    - **Asserção:** Verifica se o ID retornado é igual ao esperado.

4. **CreateProject_ReturnsNull_WhenProjectCreationFails**
    - **Descrição:** Verifica se o método `CreateProject` retorna `null` quando a criação do projeto falha.
    - **Arranjo:** Configura o mock do banco de dados para retornar `null`.
    - **Ação:** Chama o método `CreateProject` com um `ProjectModel` válido.
    - **Asserção:** Verifica se o resultado é `null`.

5. **ProjectExists_ReturnsTrue_WhenProjectExists**
    - **Descrição:** Verifica se o método `ProjectExists` retorna `true` quando o projeto existe.
    - **Arranjo:** Configura o mock do banco de dados para retornar um valor maior que 0.
    - **Ação:** Chama o método `ProjectExists` com um ID de projeto válido.
    - **Asserção:** Verifica se o resultado é `true`.

6. **ProjectExists_ReturnsFalse_WhenProjectDoesNotExist**
    - **Descrição:** Verifica se o método `ProjectExists` retorna `false` quando o projeto não existe.
    - **Arranjo:** Configura o mock do banco de dados para retornar 0.
    - **Ação:** Chama o método `ProjectExists` com um ID de projeto inválido.
    - **Asserção:** Verifica se o resultado é `false`.

7. **UpdateProject_WhenProjectExists_ReturnsUpdatedProject**
    - **Descrição:** Verifica se o método `UpdateProject` retorna o projeto atualizado.
    - **Arranjo:** Configura o mock do banco de dados para retornar um `ProjectDTO` atualizado.
    - **Ação:** Chama o método `UpdateProject` com um ID de projeto válido e um `ProjectModel` atualizado.
    - **Asserção:** Verifica se o projeto retornado é igual ao esperado.

8. **SynergyExists_ReturnsTrue_WhenSynergyExists**
    - **Descrição:** Verifica se o método `SynergyExists` retorna `true` quando a sinergia existe.
    - **Arranjo:** Configura o mock do banco de dados para retornar um valor maior que 0.
    - **Ação:** Chama o método `SynergyExists` com um ID de sinergia válido.
    - **Asserção:** Verifica se o resultado é `true`.

9. **SynergyExists_ReturnsFalse_WhenSynergyDoesNotExist**
    - **Descrição:** Verifica se o método `SynergyExists` retorna `false` quando a sinergia não existe.
    - **Arranjo:** Configura o mock do banco de dados para retornar 0.
    - **Ação:** Chama o método `SynergyExists` com um ID de sinergia inválido.
    - **Asserção:** Verifica se o resultado é `false`.

10. **CreateSynergyUpdate_ReturnsId_WhenSynergyUpdateIsCreated**
    - **Descrição:** Verifica se o método `CreateSynergyUpdate` retorna o ID da atualização de sinergia criada.
    - **Arranjo:** Configura o mock do banco de dados para retornar um ID válido de atualização de sinergia.
    - **Ação:** Chama o método `CreateSynergyUpdate` com um ID de sinergia válido e um `SynergyUpdateModel`.
    - **Asserção:** Verifica se o ID retornado é igual ao esperado.

11. **CreateSynergyUpdate_ReturnsNull_WhenSynergyUpdateCreationFails**
    - **Descrição:** Verifica se o método `CreateSynergyUpdate` retorna `null` quando a criação da atualização de sinergia falha.
    - **Arranjo:** Configura o mock do banco de dados para retornar `null`.
    - **Ação:** Chama o método `CreateSynergyUpdate` com um ID de sinergia válido e um `SynergyUpdateModel`.
    - **Asserção:** Verifica se o resultado é `null`.

12. **CreateSynergy_ReturnsTask**
    - **Descrição:** Verifica se o método `CreateSynergy` cria uma nova sinergia no banco de dados.
    - **Arranjo:** Configura o mock do banco de dados para executar a inserção.
    - **Ação:** Chama o método `CreateSynergy` com um `SynergyModel` válido.
    - **Asserção:** Verifica se o método `ExecuteAsync` foi chamado uma vez.

13. **GetSynergiesByProjectId_ReturnsSynergies_WhenProjectIdIsValid**
    - **Descrição:** Verifica se o método `GetSynergiesByProjectId` retorna uma lista de sinergias quando o ID do projeto é válido.
    - **Arranjo:** Configura o mock do banco de dados para retornar uma lista de `SynergyDTO`.
    - **Ação:** Chama o método `GetSynergiesByProjectId` com um ID de projeto válido.
    - **Asserção:** Verifica se a lista de sinergias retornada é igual à esperada.

14. **GetSynergiesByProjectId_ReturnsEmptyArray_WhenNoSynergiesFoundForProjectId**
    - **Descrição:** Verifica se o método `GetSynergiesByProjectId` retorna uma lista vazia quando não existem sinergias associadas ao projeto.
    - **Arranjo:** Configura o mock do banco de dados para retornar uma lista vazia.
    - **Ação:** Chama o método `GetSynergiesByProjectId` com um ID de projeto inválido.
    - **Asserção:** Verifica se a lista retornada está vazia.

15. **DeleteProject_ReturnsTrue_WhenProjectIsDeleted**
    - **Descrição:** Verifica se o método `DeleteProject` retorna `true` quando o projeto é deletado com sucesso.
    - **Arranjo:** Configura o mock do banco de dados para retornar 1.
    - **Ação:** Chama o método `DeleteProject` com

 um ID de projeto válido.
    - **Asserção:** Verifica se o resultado é `true`.

16. **AddRatingToProject_ReturnsRatingId_WhenRatingIsAdded**
    - **Descrição:** Verifica se o método `AddRatingToProject` retorna o ID da avaliação adicionada quando a avaliação é criada com sucesso.
    - **Arranjo:** Configura o mock do banco de dados para retornar um ID válido de avaliação.
    - **Ação:** Chama o método `AddRatingToProject` com um ID de projeto válido e um `RatingModel`.
    - **Asserção:** Verifica se o ID da avaliação retornado é igual ao esperado.

#### UserRepositoryTests

**Objetivo:** Verificar se os métodos do `UserRepository` funcionam corretamente e retornam os resultados esperados.

1. **GetUserById_ReturnsUser_WhenUserExists**
    - **Descrição:** Verifica se o método `GetUserById` retorna um usuário existente.
    - **Arranjo:** Configura o mock do banco de dados para retornar um `UserDTO`.
    - **Ação:** Chama o método `GetUserById` com um ID de usuário válido.
    - **Asserção:** Verifica se o usuário retornado é igual ao esperado.

2. **GetUserById_ReturnsNull_WhenUserDoesNotExist**
    - **Descrição:** Verifica se o método `GetUserById` retorna `null` quando o usuário não existe.
    - **Arranjo:** Configura o mock do banco de dados para retornar `null`.
    - **Ação:** Chama o método `GetUserById` com um ID de usuário inválido.
    - **Asserção:** Verifica se o resultado é `null`.

&emsp;&emsp;Esses testes garantem que os métodos dos repositórios estão interagindo corretamente com o banco de dados simulado e retornando os resultados esperados. Eles ajudam a detectar problemas na lógica de acesso a dados e a assegurar que as operações de CRUD (Create, Read, Update, Delete) estão funcionando conforme o esperado.

## 10.4 Integração do Modelo de Recomendação

&emsp;&emsp;O ecossistema do modelo de recomendação está estruturado como um serviço à parte, utilizando uma arquitetura orientada a serviços (SOA). Esta abordagem modulariza o sistema, permitindo maior flexibilidade, manutenção e escalabilidade. O serviço de recomendação, denominado ```RecommendationService```, é responsável pelas funções principais relacionadas ao modelo de recomendação, como a conexão ao banco de dados, a população da tabela de recomendações e as queries necessárias para o retreino do sistema.

&emsp;&emsp;As funcionalidades de conexão e manipulação do banco de dados estão organizadas no diretório ```dbUtils```, enquanto que a leitura do modelo, aplicação de previsões, pipeline inicial de retreino, alinhamento dos dados e ordenação dos projetos recomendados estão disponíveis no diretório ```ModelUtils```.

```
RecommendationService
    ├───dbUtils
    └───ModelUtils
```

&emsp;&emsp;Dessa forma, o ecossistema permanece organizado e focado nas funções essenciais. A integração das recomendações com a interface de usuário ocorre por meio do endpoint ````projects/users/{id}/recommendations```` (um GET), que faz parte da API REST do LegacyLab. Este endpoint está localizado junto às outras rotas relacionadas aos projetos cadastrados no banco de dados.

&emsp;&emsp;Os desenvolvedores escolheram essa lógica de integração para manter as rotas relacionadas aos projetos juntas, garantindo uma organização clara e coesa. Isso facilita a navegação e o entendimento do sistema como um todo, além de simplificar a manutenção e atualização do código. Manter as rotas de projetos agrupadas permite que qualquer alteração ou expansão futura nas funcionalidades de projetos seja realizada de forma mais integrada e eficiente, promovendo uma melhor separação de responsabilidades e assegurando que cada parte do sistema opere dentro de seu domínio específico. Dessa forma, o endpoint mencionado e a rota desenvolvida se encontram no serviço ```CoreService```, no backend da solução.

#### Swagger UI

&emsp;&emsp;A rota de API REST para a busca por projetos recomendados foi documentada e disponibilizada no Swagger UI, permitindo que os desenvolvedores visualizem e testem a integração com a API de forma interativa. Abaixo é possível visualizar um exemplo de requisição e resposta da rota de busca por projetos recomendados, mostrando exatamente como a rota funciona e como os dados são enviados e recebidos.

<div align="center">
  <sub>Figura 68: Requisição da Rota (userId = 2)</sub><br>
  <img src="./images/system/recommendations-request.png" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

<div align="center">
  <sub>Figura 69: Resposta da Rota</sub><br>
  <img src="./images/system/recommendation-response.png" width="100%"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Em conclusão, a integração do modelo de recomendação com a API REST do LegacyLab garante uma interface eficiente e organizada para o usuário final. A arquitetura orientada a serviços facilita a manutenção e o desenvolvimento contínuo do sistema, enquanto a documentação no Swagger UI promove uma comunicação clara e precisa entre os desenvolvedores.

### 10.4.1 Testes de Integração do Modelo de Recomendação

&emsp;&emsp;Nesse cenário, os testes de integração verificam a comunicação final entre as rotas disponíveis no backend e o banco de dados. Além disso, a renderização correta dos projetos recomendados também se encontra nesse contexto de testes. Esses testes foram executados e definidos junto aos testes da API do LegacyLab, disponíveis na seção [10.2 Testes de Integração](#102-teste-de-integracao) desse documento.


### 10.4.2 Diagrama de Sequência UML

&emsp;&emsp;Com o objetivo de criar uma linguagem de modelagem comum e largamente utilizada, em 1995 foi lançada a UML (Unified Modeling Language). Essa linguagem de modelagem  é uma linguagem-padrão para a elaboração da estrutura de projetos de software, ela é aplicada nos diagramas UML, em particular nesta seção, explica-se o diagrama de sequência. Esse diagrama é uma representação visual de um sistema que que descreve como objetos em um sistema interagem em uma determinada sequência de eventos. A seguir será feito o recorte da funcionalidade do sistema em relação á recomendação de projetos.

&emsp;&emsp;O diagrama a seguir mostra a interação entre diferentes componentes do sistema para o caso de uso específico de obtenção de projetos recomendados no sistema LegacyLab. Este diagrama ajuda a entender como as mensagens são trocadas entre as partes envolvidas no processo, desde a interação do usuário até a consulta ao banco de dados e a exibição dos resultados.

<div align="center">
  <sub>Figura 70: Diagrama de Sequência UML</sub><br>
  <img src="./images/system/umlRecommendations.png" alt="UML Recommendations"><br>
  <sup>Fonte: Elaborado por LegacyLab</sup>
</div>

&emsp;&emsp;Ao atentar-se aos elementos do diagrama, é possível conferir:

- **Objetos**:
  - **Usuário**: Representa o usuário que interage com o sistema.
  - **Frontend (Home)**: A interface do usuário.
  - **RecommendationsController**: *Controller* responsável por lidar com as solicitações de recomendações.
  - **ProjectRepository**: Repositório que interage com o banco de dados para buscar os projetos recomendados.
  - **Banco de Dados**: Armazena os dados dos projetos recomendados pelo modelo.

- **Funções Síncronas e Assíncronas**:
  - As funções síncronas não são executadas "de cima para baixo", de maneira linear. Isso significa que cada linha de código espera que a linha anterior seja executada antes de começar a executar. No caso, elas não são presentes nesse recorte do sistema.
  - As funções assíncronas executam uma tarefa em "segundo plano", sem o controle direto disso e sem explicitamente trabalhar com threads e coordená-las.Esse cenário ocorre em ```getRecommendedProjects``` (frontend), ```GetRecommendedProjects``` (controller) e ao buscar no banco de dados os projetos recomendados.

&emsp;&emsp;Assim, pode-se analisar a lógica representada no diagrama:
  1. **Usuário entra na Home do sistema**: O usuário acessa a página inicial do sistema (Frontend).
  2. **Frontend chama getRecommendedProjects(userId)**: O frontend envia uma solicitação ao RecommendationsController para obter os projetos recomendados para o usuário identificado pelo `userId`.
  3. **RecommendationsController chama GetRecommendedProjects(userId)**: O controlador de recomendações processa a solicitação.
  4. **ProjectRepository busca projetos recomendados**: O controlador consulta o repositório de projetos para buscar os projetos recomendados.
  5. **Banco de Dados retorna projetos**: O banco de dados devolve os projetos recomendados ao repositório.
  6. **ProjectRepository retorna Ok(projects)**: O repositório retorna os projetos obtidos ao controlador de recomendações.
  7. **RecommendationsController retorna a lista de projetos**: O controlador envia a lista de projetos recomendados de volta ao frontend.
  8. **Frontend exibe projetos recomendados**: Finalmente, o frontend exibe os projetos recomendados ao usuário.

&emsp;&emsp;Portanto, os diagramas UML são ferramentas essenciais para guiar os desenvolvedores no entendimento dos recortes importantes de um sistema. Eles oferecem uma visão clara de como os componentes interagem entre si, o que facilita a comunicação entre a equipe de desenvolvimento e outros stakeholders. No caso do projeto LegacyLab, o diagrama de sequência detalha o fluxo de dados e as interações necessárias para fornecer recomendações personalizadas de projetos, ajudando a garantir que todos os aspectos críticos do processo sejam considerados e corretamente implementados.

# 11. Procedimento de Implantação da Solução

&emsp;&emsp;A implantação de uma solução de software envolve uma série de etapas detalhadas e coordenadas que garantem a correta configuração e operação do sistema. Este manual visa fornecer um guia abrangente para a implantação da solução, abordando tanto a configuração do backend desenvolvido em C# quanto o frontend em React Native. Além disso, inclui instruções específicas para a implantação do banco de dados PostgreSQL, assegurando que todos os componentes do sistema estejam adequadamente configurados e funcionais. Este procedimento foi elaborado para ser seguido de maneira sequencial, visando minimizar erros e assegurar uma transição suave do ambiente de desenvolvimento para o de produção.

## 11.1 Procedimento de Implantação do Sistema

**1. Criar a Instância EC2**

1. **Acessar o Console AWS**
   - Vá para o Console de Gerenciamento da AWS e navegue até a seção EC2.
   - Clique em "*Launch Instance*" (Iniciar Instância).

2. **Configurar a Instância**
   - Escolha o Amazon Linux como a AMI (*Amazon Machine Image*).
   - Selecione o tipo de instância conforme necessário (t2.micro é uma boa opção para testes).

3. **Configurar a Segurança**
   - Adicione regras ao grupo de segurança:
     - Porta 5220 (TCP) para tráfego de entrada.
     - Porta 5230 (TCP) para tráfego de entrada.
     - Porta 22 (TCP) para SSH.
     - Permita todo o tráfego de saída.

4. **Criar e Conectar à Instância**
   - Clique em "*Review and Launch*".
   - Conecte-se à instância usando SSH:
     ```bash
     ssh -i ~/.ssh/minha-chave.pem ec2-user@your-ec2-public-dns
     ```

**2. Configurar o Ambiente na Instância EC2**

1. **Instalar Docker**
   ```bash
   sudo yum update -y
   sudo yum install -y docker
   sudo service docker start
   sudo systemctl enable docker
   sudo usermod -aG docker ec2-user
   exit
   ```

2. **Reconectar à Instância**
   ```bash
   ssh -i ~/.ssh/minha-chave.pem ec2-user@your-ec2-public-dns
   ```

3. **Instalar Docker Compose**
   ```bash
   sudo curl -L "https://github.com/docker/compose/releases/latest/download/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
   sudo chmod +x /usr/local/bin/docker-compose
   sudo ln -s /usr/local/bin/docker-compose /usr/bin/docker-compose
   ```

4. **Clonar o Repositório Git**
   ```bash
   git clone https://<your-token>@github.com/<your-username>/<your-repo>.git
   cd <your-repo>
   ```

5. **Adicionar Configurações**
   - Adicione o arquivo `appsettings.Development.json` nas pastas `Auth Service` e `Core Service`:
     ```bash
     vim appsettings.Development.json
     ```
   - No editor Vim, pressione "i" para entrar no modo de inserção, cole as configurações, pressione "Esc", digite ":wq" e pressione Enter para salvar e sair.

6. **Construir e Iniciar os Contêineres**
   ```bash
   docker-compose build
   docker-compose up -d
   ```

**3. Configurar o Frontend (React Native)**

1. **Instalar Node.js e npm**

- **Windows:**
  - Baixe e instale do [site oficial do Node.js](https://nodejs.org/).

- **macOS:**
  ```bash
  brew install node
  ```

- **Linux:**
  ```bash
  sudo apt update
  sudo apt install nodejs npm
  ```

2. **Instalar e Configurar o Expo CLI**

1. **Instalar o Expo CLI**
   ```bash
   npm install -g expo-cli
   ```

2. **Instalar o eas-cli**
   - Siga as instruções no [site oficial do Expo](https://docs.expo.dev/submit/android/).

3. **Configurar o Projeto React Native**

1. **Clonar o Repositório**
   ```bash
   git clone https://<your-token>@github.com/<your-username>/<your-repo>.git
   cd <your-repo>
   ```

2. **Instalar Dependências**
   ```bash
   npm install
   ```

3. **Configurar Variáveis de Ambiente**
   - Modifique o arquivo `eas.json` para buildar como apk e incluir as chaves de API:
     ```json
     {
       "cli": {
         "version": ">= 10.0.2"
       },
       "build": {
         "development": {
           "developmentClient": true,
           "distribution": "internal"
         },
         "production": {
           "env": {
             "EXPO_PUBLIC_AUTH_API_BASE_URL": "http://api_url",
             "EXPO_PUBLIC_CORE_API_BASE_URL": "http://another_api_url"
           },
           "android": {
             "buildType": "apk"
           }
         }
       },
       "submit": {
         "production": {}
       }
     }
     ```

4. **Buildar o APK**
   - Siga o tutorial do [site oficial do Expo](https://docs.expo.dev/build/setup/).

5. **Distribuir o APK**
   - Depois de buildar o APK, distribua-o conforme necessário (enviar para dispositivos, Google Play, etc).

### 11.2 Procedimento de Implantação do Banco de Dados

**1. Configuração do Banco de Dados PostgreSQL**

1. **Criar uma Instância de Banco de Dados PostgreSQL**
   - Acesse o Console da AWS e vá para a seção RDS.
   - Clique em "*Create database*" e selecione PostgreSQL.
   - Configure as opções de instância e segurança conforme necessário.
   - Anote as informações de conexão (*host, dbname, user, password*).

**2. Executar Migrations Manuais**

1. **Preparar o Ambiente**
   - Instale as bibliotecas necessárias no ambiente local ou na instância EC2:
     ```bash
     sudo yum install -y python3
     sudo pip3 install pandas psycopg2
     ```

2. **Configurar Variáveis de Ambiente**
   - Defina as variáveis de ambiente para conectar ao banco de dados:
     ```bash
     export DB_HOST="silly.db.elephantsql.com"
     export DB_NAME="fybsgwhw"
     export DB_USER="fybsgwhw"
     export DB_PASSWORD="8AkJLYBb4Tn2TxOeny1ticpIicwHxrEA"
     export DB_PORT=5432
     ```

3. **Executar os Scripts de População do Banco de Dados**
   - Navegue até o diretório `src/data/DB_Population/population`:
     ```bash
     cd src/data/DB_Population/population
     ```

   - Execute os scripts Python para popular o banco de dados:
     ```bash
     python3 population_script.py
     ```

## 11.3 Documentação Automática do Backend

&emsp;&emsp;A documentação automática do backend é uma prática essencial para garantir a transparência e a compreensão do sistema, permitindo que desenvolvedores, testadores e outros envolvidos tenham acesso a informações detalhadas sobre as rotas, parâmetros, respostas e outros aspectos da API.

&emsp;&emsp;Para o LegacyLab, a documentação do backend foi gerada automaticamente a partir da ferramenta Swagger, que permite a criação de uma documentação interativa e detalhada da API. A documentação gerada pelo Swagger é uma representação visual e interativa das rotas e operações disponíveis no backend, incluindo informações sobre os parâmetros necessários, os tipos de dados esperados, as respostas possíveis e outros detalhes relevantes.

&emsp;&emsp;A documentação automática do backend é uma ferramenta valiosa para facilitar o desenvolvimento, o teste e a manutenção do sistema, fornecendo uma referência clara e atualizada sobre as funcionalidades e operações disponíveis na API. Isso não só facilita a integração por parte de outros desenvolvedores e stakeholders que precisam interagir com a API, mas também ajuda a garantir a consistência entre o que a API promete oferecer e o que realmente fornece, reduzindo assim possíveis mal-entendidos e erros de implementação.

&emsp;&emsp;Além disso, a documentação gerada pelo Swagger é sempre atualizada com a última versão da API, uma vez que é gerada diretamente a partir do código-fonte. Isso garante que qualquer mudança na API seja automaticamente refletida na documentação, ajudando a manter todos os interessados no mesmo nível de entendimento sem a necessidade de atualizações manuais da documentação.

&emsp;&emsp;Para acessar a documentação automática do backend do LegacyLab siga os passos abaixo:

1. Inicie o servidor com o comando `dotnet run` na pasta raiz do serviço do backend desejado.
2. Abra um navegador e acesse a URL da documentação da API, que é `http://localhost:porta/swagger-ui.html`, onde `porta` é a porta em que o serviço está sendo executado.

&emsp;&emsp;Para o Serviço Core, após iniciar o servidor a documentação da API pode ser acessada em `http://localhost:5220/swagger-ui.html`.

&emsp;&emsp;Para o Serviço de Autenticação, após iniciar o servidor a documentação da API pode ser acessada em `http://localhost:5230/swagger-ui.html`.

&emsp;&emsp;Com a documentação automática do backend disponível, os desenvolvedores e outros envolvidos no projeto podem explorar e interagir com a API de forma eficiente e eficaz, garantindo uma integração facilitada e bem-sucedida com o sistema.

# 12. Aperfeiçoamentos Futuros

&emsp;&emsp;Durante o desenvolvimento do projeto "CEO's Legacy", nossa equipe considerou diversas funcionalidades além das implementadas. Devido ao prazo limitado de 10 semanas, estas não foram desenvolvidas, mas gostaríamos de destacar algumas como possíveis melhorias que poderiam enriquecer significativamente a experiência do usuário. Abaixo, listamos algumas sugestões de aperfeiçoamentos futuros para o projeto:

### Notificações

&emsp;&emsp;Implementar um sistema de notificações para alertar os usuários sobre novas sinergias e atualizações importantes poderia manter os CEOs mais engajados e informados sobre as atividades relevantes na plataforma. Esse sistema aumentaria a interatividade e dinamismo, promovendo um engajamento contínuo dos usuários.

### Processo de Sinergias

&emsp;&emsp;Propomos aprimorar o processo de criação de sinergias, introduzindo uma etapa de aceitação mútua. Esta etapa envolveria a notificação do CEO alvo sobre uma proposta de sinergia, exigindo sua confirmação antes de oficializar a colaboração, fortalecendo assim a base para colaborações efetivas e consentidas. Além disso, sugerimos incluir a possibilidade de adicionar atualizações em sinergias já existentes para manter todos informados sobre o progresso.

### Validações no Backend

&emsp;&emsp;Reforçar as validações no backend é crucial para melhorar a segurança e a eficiência da plataforma. Isso incluiria a implementação de verificações avançadas de entrada de dados para prevenir erros comuns de usuário e ataques cibernéticos, garantindo uma operação mais segura e confiável.

### Personalização de Perfis

&emsp;&emsp;Permitir a personalização dos perfis dos usuários com fotos e outras informações pessoais promoveria uma maior conexão e interação entre os membros da comunidade. Essa funcionalidade tornaria a rede mais pessoal e engajadora, aumentando o sentimento de comunidade entre os CEOs.

### Perfil Administrativo

&emsp;&emsp;A criação de um perfil administrativo robusto para a Fundação Dom Cabral permitiria uma gestão mais completa e eficaz de todas as funcionalidades e dados da plataforma. Este perfil teria acesso a relatórios avançados, ferramentas de análise de dados e capacidades de edição e remoção de conteúdos, garantindo uma supervisão eficiente e adaptativa das interações na plataforma.

&emsp;&emsp;Essas são apenas sugestões para possíveis implementações futuras que a equipe Legacy Lab identificou durante a fase inicial do desenvolvimento do "CEO's Legacy". A inclusão dessas funcionalidades em futuras versões dependerá da avaliação das partes interessadas e da estratégia de desenvolvimento. Esperamos que essas recomendações sirvam como um ponto de partida para enriquecer ainda mais o projeto e maximizar o valor oferecido aos usuários finais e à Fundação Dom Cabral.

# Referências

[Seção 3.6](#36-estimativa-de-investimento): 

[Média salarial Desenvolvedor Júnior](https://www.glassdoor.com.br/Sal%C3%A1rios/desenvolvedor-junior-sal%C3%A1rio-SRCH_KO0,20.htm)

[Média salarial Desenvolvedor Sênior](https://br.indeed.com/career/desenvolvedor-java-s%C3%AAnior/salaries/Estado-de-S%C3%A3o-Paulo)

[Média salarial *Product owner*](https://www.glassdoor.com.br/Sal%C3%A1rios/product-owner-po-sal%C3%A1rio-SRCH_KO0,16.htm#:~:text=A%20remunera%C3%A7%C3%A3o%20vari%C3%A1vel%20do%20cargo)

# Apêndice
