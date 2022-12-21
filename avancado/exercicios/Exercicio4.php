<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercícios</title>
</head>
<body>

	<h1>Exercício 4</h1>

	<form action="Exercicio4.php" method="post">

            <p>
                <input type="radio" name="um" id="pedra" value="pedra"/>
                <label for="pedra">Pedra</label>
                <br>
                <br>
                <input type="radio" name="um" id="papel" value="papel"/>
                <label for="papel">Papel</label>
                <br>
                <br>
                <input type="radio" name="um" id="tesoura" value="tesoura"/>
                <label for="tesoura">Tesoura</label>
            </p>
            <p>
                <input type="submit" value="Enviar" id="btnEnviar" name="btnEnviar">
            </p>
    </form>

	<?php
	error_reporting(0);

	$jogador = $_POST['um'];
	$computador = rand(0,2);
	//0 é pedra
	//1 é papel
	//2 é tesoura

	echo "JOKENPO<br><br>";

	if($computador == 0 && $jogador=="pedra"){
		//pedra com pedra
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : pedra<br>";
		echo "Empate";
	}
	else if($computador == 0 && $jogador=="papel"){
		//pedra com papel
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : pedra<br>";
		echo "Vencedor: jogador";
	}
	else if($computador == 0 && $jogador=="tesoura"){
		//pedra com tesoura
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : pedra<br>";
		echo "Vencedor: computador";
	}

	else if($computador == 1 && $jogador=="pedra"){
		//papel com pedra
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : papel<br>";
		echo "Vencedor: jogador";
	}
	else if($computador == 1 && $jogador=="papel"){
		//papel com papel
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : papel<br>";
		echo "Empate";
	}
	else if($computador == 1 && $jogador=="tesoura"){
		//papel com tesoura
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : papel<br>";
		echo "Vencedor: jogador";
	}

	else if($computador == 2 && $jogador=="pedra"){
		//tesoura com pedra
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : tesoura<br>";
		echo "Vencedor: computador";
	}
	else if($computador == 2 && $jogador=="papel"){
		//tesoura com papel
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : tesoura<br>";
		echo "Vencedor: computador";
	}
	else if($computador == 2 && $jogador=="tesoura"){
		//tesoura com tesoura
		echo "Escolha do jogador : $jogador<br>";
		echo "Escolha do computador : tesoura<br>";
		echo "Empate";
	}

	?>

</body>
</html>