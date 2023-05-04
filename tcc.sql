-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Nov-2022 às 04:21
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `tcc`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cadastro`
--

CREATE TABLE `tb_cadastro` (
  `id_cadastro` int(11) NOT NULL,
  `Nome` varchar(75) NOT NULL,
  `nome_responsavel` varchar(75) NOT NULL,
  `cpf_responsavel` char(20) NOT NULL,
  `cpf` char(20) NOT NULL,
  `como_ficou_sabendo` varchar(1000) NOT NULL,
  `rg_responsavel` varchar(20) NOT NULL,
  `rg` varchar(20) NOT NULL,
  `e_mail` varchar(80) NOT NULL,
  `data_nascimento` date NOT NULL,
  `numero_telefone` varchar(25) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `id_endereco` int(11) NOT NULL,
  `id_escolaridade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_curso`
--

CREATE TABLE `tb_curso` (
  `id_curso` int(11) NOT NULL,
  `nome_curso` varchar(100) NOT NULL,
  `requisitos` varchar(1000) NOT NULL,
  `descricao` varchar(1000) NOT NULL,
  `localizacao` varchar(60) NOT NULL,
  `preco` decimal(7,2) NOT NULL,
  `carga_horaria` varchar(15) NOT NULL,
  `id_tipo_curso` int(11) NOT NULL,
  `id_modalidade` int(11) NOT NULL,
  `id_turno` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_curso`
--

INSERT INTO `tb_curso` (`id_curso`, `nome_curso`, `requisitos`, `descricao`, `localizacao`, `preco`, `carga_horaria`, `id_tipo_curso`, `id_modalidade`, `id_turno`) VALUES
(1, 'Desenvolvimento de Sistemas', 'Ensino Médio Incompleto', 'Um dos setores mais produtivos atualmente, a TI abre espaço no mercado de trabalho para muitos profissionais. E um deles pode ser você ao fazer o Curso Técnico em Desenvolvimento de Sistemas. Com essa formação, seu futuro estará no desenvolvimento de sistemas computacionais, na linguagem de programação e análise de dados, além da manutenção de programas de computador.', 'Campus da Industria', '429.00', '18 Meses', 1, 2, 5),
(2, 'Técnico em Edificações', 'Ensino Médio Incompleto', 'Um dos setores mais dinâmicos do Brasil, a área da construção precisa de profissionais competentes e preparados para preencher as vagas disponíveis no mercado. Com o Curso Técnico em Edificações, você poderá ser um deles. O diploma permitirá que você elabore o orçamento das obras, faça pesquisas tecnológicas, coordene a execução de serviços de manutenção de equipamentos e de instalações em edificações e, o mais importante, consiga um bom emprego.', 'Campus da Industria', '549.00', '24 Meses', 1, 2, 3),
(3, 'Técnico em Administração', 'Ensino Médio Incompleto', 'Todos os segmentos de empresas e indústrias precisam de bons gestores, por isso o técnico em Administração tem todos os motivos para se dar bem no mercado de trabalho. Como profissional técnico, você entenderá de administração, vendas, logística, finanças e planejamento estratégico para executar ações relativas a protocolos e arquivos, confecção e expedição de documentos e controle de estoques, podendo ser também um dos responsáveis por formar equipes motivadas e melhorar a produtividade das empresas.', 'Senai Portão', '239.00', '18 Meses', 1, 1, 3),
(4, 'Aperfeiçoamento Profissional em Excel Básico', '- Ter o Microsoft Excel instalado.\r- Ter no mínimo 14 anos completos no ato da matrícula.\r- Comprovante de Residência\r - CPF do Aluno\r- RG do Aluno', 'Introdução às fórmulas básicas através dos operadores e prioridades aritméticas. \nFunções aritméticas básicas para soluções do dia a dia; Apresentação das referências relativas, absolutas e mistas das células.', 'Curitiba Dr Celso Charuri', '76.00', '20 Horas', 2, 3, 7),
(5, 'Aperfeiçoamento Profissional em Informática', '- Fundamental Incompleto\r - Comprovante de Residência\r - CPF do Aluno\r - RG do Aluno', 'Capacitar o participante nas ferramentas do office 365, desenvolvendo competências profissionais direcionadas a informática.', 'Senai Colombo', '350.00', '60 Horas', 2, 2, 5),
(6, 'Aperfeiçoamento Profissional em Gestão e Liderança', '\r- Ensino Fundamental Incompleto\r - Comprovante de Residência\r - CPF do Aluno\r - RG do Aluno', 'Aprimore-se nas relações humanas com técnicas de liderança e gestão', 'Senai Palmas', '350.00', '40 Horas', 2, 3, 3),
(7, 'Aprendizagem Industrial para Assistente Adminstrativo', '\r- Estar regularmente matriculado no Ensino Fundamental ou Médio ou ter concluído o Ensino Médio.\r- Certificado de Reservista\r - Comprovante de Escolaridade\r - Comprovante de Quitação Eleitoral\r - Comprovante de Residência\r - Contrato com Assinatura', 'Realizar rotinas administrativas, auxiliar no processo de controle de materiais, seguindo normas e procedimentos internos em conformidade com normas de saúde, \nhigiene, meio ambiente e segurança.', 'Senai Arapongas', '560.00', '960 Horas', 3, 2, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_endereco`
--

CREATE TABLE `tb_endereco` (
  `id_endereco` int(11) NOT NULL,
  `estado` varchar(60) NOT NULL,
  `cidade` varchar(60) NOT NULL,
  `numero_casa` int(5) NOT NULL,
  `rua` varchar(45) NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `cep` int(11) NOT NULL,
  `complemento` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_escolaridade`
--

CREATE TABLE `tb_escolaridade` (
  `id_escolaridade` int(11) NOT NULL,
  `tipo_escolaridade` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_escolaridade`
--

INSERT INTO `tb_escolaridade` (`id_escolaridade`, `tipo_escolaridade`) VALUES
(1, 'Ensino Fundamental Completo'),
(2, 'Ensino Medio Imcompleto'),
(3, 'Ensino Medio Completo');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_evento`
--

CREATE TABLE `tb_evento` (
  `id_evento` int(11) NOT NULL,
  `nome_evento` varchar(45) NOT NULL,
  `data_evento` date NOT NULL,
  `palestrante` varchar(45) NOT NULL,
  `preco` decimal(5,2) NOT NULL,
  `id_unidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_matricula`
--

CREATE TABLE `tb_matricula` (
  `id_matricula` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL,
  `id_cadastro` int(11) NOT NULL,
  `id_unidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_modalidade`
--

CREATE TABLE `tb_modalidade` (
  `id_modalidade` int(11) NOT NULL,
  `modalidade` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_modalidade`
--

INSERT INTO `tb_modalidade` (`id_modalidade`, `modalidade`) VALUES
(1, 'Semipresencial'),
(2, 'Presencial'),
(3, 'Ensino a Distancia EaD');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tipo_curso`
--

CREATE TABLE `tb_tipo_curso` (
  `id_tipo_curso` int(11) NOT NULL,
  `tipo_curso` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_tipo_curso`
--

INSERT INTO `tb_tipo_curso` (`id_tipo_curso`, `tipo_curso`) VALUES
(1, 'Curso Técnico'),
(2, 'Curso Rápido'),
(3, 'Aprendizagem Industrial');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_turno`
--

CREATE TABLE `tb_turno` (
  `id_turno` int(11) NOT NULL,
  `tipo_turno` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_turno`
--

INSERT INTO `tb_turno` (`id_turno`, `tipo_turno`) VALUES
(1, 'Matutino'),
(2, 'Vespertino'),
(3, 'Noturno'),
(4, 'Matutino e Vespertino'),
(5, 'Vespertino e Noturno'),
(6, 'Matutino e Noturno'),
(7, 'Matutino,Vespertino e Noturno');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_unidade`
--

CREATE TABLE `tb_unidade` (
  `id_unidade` int(11) NOT NULL,
  `nome_unidade` varchar(45) NOT NULL,
  `id_endereco` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_cadastro`
--
ALTER TABLE `tb_cadastro`
  ADD PRIMARY KEY (`id_cadastro`),
  ADD UNIQUE KEY `cpf_responsavel` (`cpf_responsavel`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD KEY `fk_id_endereco` (`id_endereco`),
  ADD KEY `fk_id_escolaridade2` (`id_escolaridade`);

--
-- Índices para tabela `tb_curso`
--
ALTER TABLE `tb_curso`
  ADD PRIMARY KEY (`id_curso`),
  ADD KEY `fk_id_turno` (`id_turno`),
  ADD KEY `fk_tipo_curso` (`id_tipo_curso`),
  ADD KEY `fk_id_modalidade` (`id_modalidade`);

--
-- Índices para tabela `tb_endereco`
--
ALTER TABLE `tb_endereco`
  ADD PRIMARY KEY (`id_endereco`);

--
-- Índices para tabela `tb_escolaridade`
--
ALTER TABLE `tb_escolaridade`
  ADD PRIMARY KEY (`id_escolaridade`);

--
-- Índices para tabela `tb_evento`
--
ALTER TABLE `tb_evento`
  ADD PRIMARY KEY (`id_evento`),
  ADD KEY `fk_id_unidade` (`id_unidade`);

--
-- Índices para tabela `tb_matricula`
--
ALTER TABLE `tb_matricula`
  ADD PRIMARY KEY (`id_matricula`),
  ADD KEY `fk_id_curso` (`id_curso`),
  ADD KEY `fk_id_cadastro` (`id_cadastro`),
  ADD KEY `fk_id_unidade2` (`id_unidade`);

--
-- Índices para tabela `tb_modalidade`
--
ALTER TABLE `tb_modalidade`
  ADD PRIMARY KEY (`id_modalidade`);

--
-- Índices para tabela `tb_tipo_curso`
--
ALTER TABLE `tb_tipo_curso`
  ADD PRIMARY KEY (`id_tipo_curso`);

--
-- Índices para tabela `tb_turno`
--
ALTER TABLE `tb_turno`
  ADD PRIMARY KEY (`id_turno`);

--
-- Índices para tabela `tb_unidade`
--
ALTER TABLE `tb_unidade`
  ADD PRIMARY KEY (`id_unidade`),
  ADD KEY `fk_id_endereco2` (`id_endereco`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_cadastro`
--
ALTER TABLE `tb_cadastro`
  MODIFY `id_cadastro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `tb_curso`
--
ALTER TABLE `tb_curso`
  MODIFY `id_curso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `tb_endereco`
--
ALTER TABLE `tb_endereco`
  MODIFY `id_endereco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `tb_escolaridade`
--
ALTER TABLE `tb_escolaridade`
  MODIFY `id_escolaridade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tb_evento`
--
ALTER TABLE `tb_evento`
  MODIFY `id_evento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_matricula`
--
ALTER TABLE `tb_matricula`
  MODIFY `id_matricula` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_modalidade`
--
ALTER TABLE `tb_modalidade`
  MODIFY `id_modalidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tb_tipo_curso`
--
ALTER TABLE `tb_tipo_curso`
  MODIFY `id_tipo_curso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tb_turno`
--
ALTER TABLE `tb_turno`
  MODIFY `id_turno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `tb_unidade`
--
ALTER TABLE `tb_unidade`
  MODIFY `id_unidade` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `tb_cadastro`
--
ALTER TABLE `tb_cadastro`
  ADD CONSTRAINT `fk_id_endereco` FOREIGN KEY (`id_endereco`) REFERENCES `tb_endereco` (`id_endereco`),
  ADD CONSTRAINT `fk_id_escolaridade2` FOREIGN KEY (`id_escolaridade`) REFERENCES `tb_escolaridade` (`id_escolaridade`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_curso`
--
ALTER TABLE `tb_curso`
  ADD CONSTRAINT `fk_id_modalidade` FOREIGN KEY (`id_modalidade`) REFERENCES `tb_modalidade` (`id_modalidade`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_id_turno` FOREIGN KEY (`id_turno`) REFERENCES `tb_turno` (`id_turno`),
  ADD CONSTRAINT `fk_tipo_curso` FOREIGN KEY (`id_tipo_curso`) REFERENCES `tb_tipo_curso` (`id_tipo_curso`);

--
-- Limitadores para a tabela `tb_evento`
--
ALTER TABLE `tb_evento`
  ADD CONSTRAINT `fk_id_unidade` FOREIGN KEY (`id_unidade`) REFERENCES `tb_unidade` (`id_unidade`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_matricula`
--
ALTER TABLE `tb_matricula`
  ADD CONSTRAINT `fk_id_cadastro` FOREIGN KEY (`id_cadastro`) REFERENCES `tb_cadastro` (`id_cadastro`),
  ADD CONSTRAINT `fk_id_curso` FOREIGN KEY (`id_curso`) REFERENCES `tb_curso` (`id_curso`),
  ADD CONSTRAINT `fk_id_unidade2` FOREIGN KEY (`id_unidade`) REFERENCES `tb_unidade` (`id_unidade`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_unidade`
--
ALTER TABLE `tb_unidade`
  ADD CONSTRAINT `fk_id_endereco2` FOREIGN KEY (`id_endereco`) REFERENCES `tb_endereco` (`id_endereco`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
