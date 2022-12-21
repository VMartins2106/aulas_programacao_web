<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercícios</title>
</head>
<body>

	<h1>Exercício 3</h1>

	<form action="Exercicio3.php" method="post">
		
			<table border="2">
			<tr>
				<td>Informe a frase: </td>
				<td><input type="text" name="textnu1"></td>
			</tr>
			<tr>
				<td>Quantidade de vezes: </td>
				<td><input type="text" name="textnu2"></td>
			</tr>
			
		</table>

		<br>

		<input type="submit" value="Enviar" id="btnEnviar" name="btnEnviar">
	
	</form>

	<?php
	error_reporting(0);

	$frase= $_POST['textnu1'];
	$qtd= $_POST['textnu2'];

	for ($i=1; $i <= $qtd; $i++) { 
		echo "$i : $frase <br>";
	}

	?>

</body>
</html>