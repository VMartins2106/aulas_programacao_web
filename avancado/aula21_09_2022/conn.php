
<!--CONECTANDO AO BANCO-->

<?php
	try{
		$pdo = new PDO("mysql:dbname=bancoteste; host=localhost", "root", "");
		echo "Conexão feita";
		echo "<br><br>";
	}
	catch(PDOException $e){
		echo "ERRO DE CONEXÃO: ".$e->getMessage();
	}
	catch(Exception $e){
		echo "erro: ".$e->getMessage();
	}

	/*FAZENDO O CADASTRO	

	$insere = $pdo->prepare("INSERT INTO usuario (nome, email, assunto, mensagem)
		VALUES (:n, :e, :a, :msg)");
	$insere->bindValue(":n", "magrao");
	$insere->bindValue(":e", "magrao@gmail.com");
	$insere->bindValue(":a", "sei la");
	$insere->bindValue(":msg", "user 10");
	$insere->execute();*/

	/*DELETANDO

	$del = $pdo->prepare("DELETE FROM usuario WHERE id = :id");
	$id = 2;
	$del->bindValue(":id", $id);
	$del->execute();*/

	/*DELETANDO TODOS OS CADASTROS
	$del = $pdo->prepare("DELETE FROM usuario");
	$del->execute();*/

	/*FAZENDO O UPDATE

	$update = $pdo->prepare("UPDATE usuario SET mensagem = :msg WHERE id = :id");
	$msg = "AMO MUITO ELA";
	$update->bindValue(":msg", $msg);
	$id = 13;
	$update->bindValue(":id", $id);
	$update->execute();*/

	/*FAZENDO O SELECT

	$select = $pdo->prepare("SELECT * FROM usuario WHERE id = :id");
	$id = 13;
	$select->bindValue(":id", $id);
	$select->execute();
	$mostra = $select->fetch();
	print_r($mostra);

	echo "<br><br>";

	echo "<br> ORGANIZANDO O ARRAY <br>";

	echo "<pre>";
	print_r($mostra);
	echo "</pre>";
	echo "<br><br>";*/

	/*SELECT CORRETA E ORGANIZADA

	echo "EXIBIÇÃO CORRETA COM FOREACH: <br><br>";
	$select = $pdo->prepare("SELECT * FROM usuario WHERE id = :id");
	$id = 13;
	$select->bindValue(":id", $id);
	$select->execute();
	$mostra = $select->fetch(PDO::FETCH_ASSOC);
	//Exibindo com foreach - comando para percorrer arrays
		foreach($mostra as $key => $value){
			echo $key.": ".$value."<br>";
		}*/

	/*SELECT PARA TODOS OS REGISTROS

	echo "<br><br> EXIBIÇÃO DE TODOS OS REGISTROS: <br><br>";
	$select = $pdo->prepare("SELECT * FROM usuario");
	$select->execute();
	$mostra = $select->fetchAll();
	//Exibindo com foreach - comando para percorrer arrays
	echo "<br>";
		foreach($mostra as $row){
			echo $row ['id']."<br>". $row ['nome']."<br>". $row ['email']."<br>". $row ['assunto']."<br>". $row ['mensagem']."<br><br><br>";
		}*/

?>