<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercícios</title>
</head>
<body>

	<h1>Exercício 1</h1>

	<form action="Exercicio1.php" method="post">
		
			<table border="3">
			<tr>
				<td>Digite o seu ano de nascimento:</td>
				<td><input type="text" name="textnu1"></td>
			</tr>
			
		</table>

		<br>

		<input type="submit" value="Enviar" id="btnEnviar" name="btnEnviar">
	
	</form>

	<?php
	error_reporting(0);

	$num1= $_POST['textnu1'];
	$ano = 2022-$num1;
	
   echo "Sua idade é: $ano";

	if ($ano < 12) {

		echo "<br>Criança";
		
	}

	else if ($ano >=12 && $ano<=17) {

		echo "<br>Adolescente";
		
	}

     else if ($ano == 18 && $ano<=60) {
     	
     

     	echo "<br>Adulto";

     }

     else{

         echo "<br>Idoso";

     }

	?>

</body>
</html>