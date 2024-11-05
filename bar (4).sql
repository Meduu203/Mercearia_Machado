-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 05/11/2024 às 15:06
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bar`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cliente`
--

CREATE TABLE `cliente` (
  `Nome_cliente` varchar(100) NOT NULL,
  `CPF` varchar(14) NOT NULL,
  `Telefone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cliente`
--

INSERT INTO `cliente` (`Nome_cliente`, `CPF`, `Telefone`) VALUES
('João Silva', '26134781878', '(11)91234-5678'),
('Pedro Santos', '35006506865', '(31)95432-1234'),
('Maria Oliveira', '38865294876', '(21)99876-5432'),
('Jose Acacio Machado', '53434090835', '19997026003'),
('Ana Costa', '59738688850', '(41)98765-4321');

-- --------------------------------------------------------

--
-- Estrutura para tabela `pedido`
--

CREATE TABLE `pedido` (
  `ID_pedido` int(11) NOT NULL,
  `Nome_cliente` varchar(100) DEFAULT NULL,
  `Itens_pedido` varchar(255) DEFAULT NULL,
  `Telefone` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `pedido`
--

INSERT INTO `pedido` (`ID_pedido`, `Nome_cliente`, `Itens_pedido`, `Telefone`) VALUES
(1, 'João Silva', 'Porção de Batata Frita', '(11)91234-5678'),
(2, 'Maria Oliveira', 'Porção de Calabresa Acebolada', '(21)99876-5432'),
(3, 'Pedro Santos', 'Porção de Frango à Passarinho', '(31)95432-1234'),
(4, 'Ana Costa', 'Porção de Mandioca Frita', '(41)98765-4321'),
(5, 'Lucas Martins', 'Porção de Isca de Peixe', '(51)97654-3210');

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto`
--

CREATE TABLE `produto` (
  `Cod` int(11) NOT NULL,
  `Setor` varchar(50) DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Descricao` varchar(255) DEFAULT NULL,
  `Valor` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `produto`
--

INSERT INTO `produto` (`Cod`, `Setor`, `Nome`, `Descricao`, `Valor`) VALUES
(1, 'Porções', 'Batata', 'Batata Frita', 50.00);

-- --------------------------------------------------------

--
-- Estrutura para tabela `proprietario`
--

CREATE TABLE `proprietario` (
  `CPF` varchar(14) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `Login` varchar(50) DEFAULT NULL,
  `Senha` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `proprietario`
--

INSERT INTO `proprietario` (`CPF`, `Nome`, `Login`, `Senha`) VALUES
('53434090838', 'Marcos Machado', 'm.machado', 'meduu202');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`CPF`);

--
-- Índices de tabela `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`ID_pedido`);

--
-- Índices de tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`Cod`);

--
-- Índices de tabela `proprietario`
--
ALTER TABLE `proprietario`
  ADD PRIMARY KEY (`CPF`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `Cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
