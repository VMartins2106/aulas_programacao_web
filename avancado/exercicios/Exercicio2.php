<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercícios</title>
</head>
<body>

	<h1>Exercício 2</h1>

	<form action="Exercicio2.php" method="post">
		
		<table border="2">
			<tr>
				<td>Valor de consumo: </td>
				<td><input type="text" name="textnu1"></td>
			</tr>
			<tr>
				<td>Quantidade de pessoas: </td>
				<td><input type="text" name="textnu2"></td>
			</tr>
			<tr>
				<td>Valor couvert artístico: </td>
				<td><input type="text" name="textnu3"></td>
			</tr>			
		</table>

		<br>

		<input type = "checkbox" id = "subscribeNews" name = "subscribe" value = "newsletter">
    	<label for = "subscribeNews">Aplicar a taxa de serviço de 10% ?</label>

		<br>
		<br>
		<input type="submit" value="Enviar" id="btnEnviar" name="btnEnviar">

	</form>

	<br>

	<?php
	error_reporting(0);

	$consumo= $_POST['textnu1'];
	$quantidade= $_POST['textnu2'];
	$couvertA= $_POST['textnu3'];
	$couvert=0;
	$servico=0;
	$total=0;
	$pessoa=0;

	$couvert = $couvertA*$quantidade;

	if(isset($_POST['subscribe'])){
		$servico = $consumo*0.1;
		$total = $consumo + $couvert + $servico;
		$pessoa = $total/$quantidade;
		echo "Resumo da conta :
		<br>
		<br>
		Total do consumo: $consumo
		<br>
		Valor do couvert artistico: $couvert
		<br>
		Valor da taxa de serviço: $servico
		<br>
		Total da conta: $total
		<br>
		Valor por pessoa: $pessoa";
	}
	else{
		$total = $consumo + $couvert;
		$pessoa = $total/$quantidade;
		echo "Resumo da conta :
		<br>
		<br>
		Total do consumo: $consumo
		<br>
		Valor do couvert artistico: $couvert
		<br>
		Total da conta: $total
		<br>
		Valor por pessoa: $pessoa";
	}

	?>

</body>
</html>