<?php
    class Conexao
    {
        private $pdo;
        public function __construct($dbname,$host,$user,$senha)
        {
            try{
                $this->pdo = new PDO("mysql:dbname=".$dbname.";host=".$host,$user,$senha);
            } catch(PDOException $e){
                echo "ERRO DE CONEXÃO NO PDO: ".$e->getMessage();
                exit();
            }catch(Exception $e){
                echo "ERRO NÃO PASSOU DA CONEXÃO: ".$e->getMessage();
                exit();
            }
        }

        //FUNÇÃO PARA INSERIR OS DADOS
        public function insereDados($nome,$email,$assunto,$mensagem){
            $insere = $this->pdo->prepare("select id from usuario where email = :e");
            $insere->bindValue(":e",$email);
            $insere->execute();

            if($insere->rowCount()>0){
                return false;
            } else{
                $insere = $this->pdo->prepare("insert into usuario(nome, email, assunto, mensagem) values(:n,:e,:a,:m)");
                $insere->bindValue(":n", $nome);
                $insere->bindValue(":e", $email);
                $insere->bindValue(":a", $assunto);
                $insere->bindValue(":m", $mensagem);
                $insere->execute();
                return true;
            }
        }

        //FUNÇÃO PARA CONSULTAR TODOS OS DADOS
        public function retornaDados(){
            $retorna = array();
            $cons = $this->pdo->query("select * from usuario order by id");
            $retorna = $cons->fetchAll(PDO::FETCH_ASSOC);
            return $retorna;
        }

    }
    
?>