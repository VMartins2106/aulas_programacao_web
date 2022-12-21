<?php
    //inclui o arquivo de conexao
    require_once 'conexaoOO.php';
    //instancia a classe conexao e envia parâmetros para o banco
    $res = new Conexao("bancoteste", "localhost", "root", "");
?>

<!DOCTYPE html>
    <html lang="pt-br">
        <head>
            <link rel="stylesheet" href="estilo1.css"/>
            <meta charset="iso-8859-1" name="viewport" content="width=device-width, initial-scale=1">
            <title> PW3 - FORMULÁRIO CADASTRO COM PDO </title>
        </head>
        <body>
            <?php
                //CADASTRAR DIRETO NA INDEX
                //A FUNÇÃO ADDSLASHES CRIA UMA REGRA DE SEGURANÇA PARA VALIDAR SE NAS TEXTS NÃO CONSTA CÓDIGO MALICIOSOS
                if(isset($_POST['txtNome'])){
                    $cadNome = addslashes($_POST['txtNome']);
                    $cadEmail = addslashes($_POST['txtEmail']);
                    $cadAssunto = addslashes($_POST['txtAssunto']);
                    $cadMensagem = addslashes($_POST['txtMensagem']);
                    //VERIFICAR SE TODOS OS CAMPOS ESTÃO PREENCHIDOS COM FUNÇÃO EMPTY
                    if(!empty($cadNome) && !empty($cadEmail) && !empty($cadAssunto) && !empty($cadMensagem)){
                        if($res -> insereDados($cadNome, $cadEmail, $cadAssunto, $cadMensagem)){
                            echo "<h2> CADASTRO COM SUCESSO </h2>";
                        }
                        else{
                            echo "<h2> EMAIL JÁ CADASTRADO </h2>";
                        }
                    }else{
                        echo "<h2> PRRENCHA TODOS OS CAMPOS </h2>";
                    }
                }
            ?>

            <section id="formulario">
                <form id="txtNome" name="cadastrar" method="POST">
                    <h2>CADASTRAR USUÁRIO</h2>
                    <label for="txtNome">Nome: </label>
                    <input type=text name="txtNome" id="idNome" placeholder="Digite seu nome completo" require max= 45 minlength="8" maxlength="45">

                    <label for="txtEmail">Email: </label>
                    <input type="email" name="txtEmail" id="idEmail" placeholder="Email pessoaç" require max= 30>

                    <label for="txtAssunto">Assunto: </label>
                    <input type=text name="txtAssunto" id="idAssunto" placeholder="Assunto da mensagem" require
                    max= 45 max="45" minlength="8" maxlength="45">

                    <label for="txtMensagem">Mensagem: </label>
                    <textarea name="txtMensagem" id="idMensagem" placeholder="Digite aqui sua mensagem" require 
                    rows="3" cols="50"></textarea> 

                    <input type="submit" name="btnCadastrar" value="Cadastrar">
                </form>
            </section>
            <section id="TabelaConsulta">
                <table>
                    <tr id="titulo">
                        <td>NOME</td>
                        <td>EMAIL</td>
                        <td>ASSUNTO</td>
                        <td>MENSAGEM</td>
                    </tr>
                    <?php
                        $consulta = $res->retornaDados();
                        if(count($consulta)>0){
                            for ($i=0;$i<count($consulta);$i++){
                                echo "<tr>";
                                foreach ($consulta[$i] as $key => $value){
                                    if ($key != "id") {
                                        echo "<td>".$value."</td>";
                                    }
                                }
                                ?>
                                <td><a href="">ALTERAR</a><a href="">EXCLUIR</a></td>
                                <?php
                                    echo "</tr>";
                                }
                        } else {
                            echo "<h2>Ainda não constam registros cadastrados.</h2>";
                        }
                    ?>                          
            </table>
        </section>
    </body>
</html>