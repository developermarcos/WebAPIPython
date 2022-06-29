<?php
include("ModelClienteAPI.php");

    $titulo = "CLiente WEB API";
    $modelCliente = new ModelClienteAPI();
    $resultado = NULL;
    if(!$_POST || !isset($_POST['metodo'])){
        $resultado = "Nenhum metodo informado";
        echo $resultado;
    }
    else{
        $id = isset($_POST['id'])? $_POST['id'] : "";
        $cpf = isset($_POST['cpf'])? $_POST['cpf'] : "";
        $data = [
            "nome" => isset($_POST['nome'])? $_POST['nome'] : "",
            "idade" => isset($_POST['idade'])? $_POST['idade'] : ""
        ];
        
        switch($_POST['metodo']){
            case "GET":
                $resultado = "<p class='mensagem'>Mostra resultado GET: ".$modelCliente->SelectByID($id)."</p>";
                echo $resultado;
                break;
            case "POST":
                $resultado = "Mostra resultado POST: ".$modelCliente->Insert($data, $id);
                echo $resultado;
                break;
            case "PUT":
                $resultado = "Mostra resultado PUT: ".$modelCliente->Edit($data, $id);
                echo $resultado;
                break;
            case "DELETE":
                $resultado = "Mostra resultado DELETE: ".$modelCliente->Delete($id);
                echo $resultado;
                break;
            case "VALIDACPF":
                $valido = json_decode($modelCliente->ValidaCpf(intval($cpf)));
                if($valido == true){
                    $resultado = "Válido";
                }else{
                    $resultado = "Inválido";
                }
                echo "Status CPF: ".$resultado;
                break;
        }
    }
    

?>
<!doctype html>
<html lang="pt-br">
<head>
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

</head>
<body>

<br>
<br>
<a href="index.php">Voltar</a>
<style>
    a{
        padding: 15px 30px;
        background: green;
        color: white;
        font-weight: 600;
        border-radius: 5px;
        text-decoration: none;
    }
    a:hover{
        text-decoration: underline;
        transition: 0.3s
    }
    p{
        padding: 30px;
        border: 3px solid grey;
    }
</style>
</body>
</html>