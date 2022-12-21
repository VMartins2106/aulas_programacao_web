-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Set-2022 às 22:42
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 8.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bancoteste`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `nome` varchar(60) NOT NULL,
  `email` varchar(40) NOT NULL,
  `assunto` varchar(30) NOT NULL,
  `mensagem` text NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`nome`, `email`, `assunto`, `mensagem`, `id`) VALUES
('victor', 'victor@gmail.com', 'sei la', 'user 1', 22),
('nathália', 'nathália@gmail.com', 'sei la', 'user 2', 23),
('b helder', 'Bhelder@gmail.com', 'sei la', 'user 3', 24),
('biel', 'biel@gmail.com', 'sei la', 'user 4', 25),
('yan', 'yan@gmail.com', 'sei la', 'user 5', 26),
('macedo', 'macedo@gmail.com', 'sei la', 'user 6', 27),
('kairy', 'kairy@gmail.com', 'sei la', 'user 7', 28),
('samuel', 'samuel@gmail.com', 'sei la', 'user 8', 29),
('botoni', 'botoni@gmail.com', 'sei la', 'user 9', 30),
('magrao', 'magrao@gmail.com', 'sei la', 'user 10', 31),
('ROVILSON', 'rov@gmail.com', 'sfcasdabdhsadbhkiashca', 'user 11', 32);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
