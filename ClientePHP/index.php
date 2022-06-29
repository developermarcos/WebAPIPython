<!doctype html>
<html lang="pt-br">
<head>
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <title>
    <?php
      if(isset($titulo)) {
        echo $titulo . ' | ';
      } 
    ?>
  </title>
</head>
<body>
  <form action="form.php" method="post">
    <h1>CRUD Usuário</h1>
    <div class="radio">
      <input type="radio" id="GET" name="metodo" value="GET">
      <label for="GET">GET</label>
    </div>

    <div class="radio">
      <input type="radio" id="POST" name="metodo" value="POST">
      <label for="POST">POST</label>
    </div>

    <div class="radio">
      <input type="radio" id="PUT" name="metodo" value="PUT">
      <label for="PUT">PUT</label>
    </div>

    <div class="radio">
      <input type="radio" id="DELETE" name="metodo" value="DELETE">
      <label for="DELETE">DELETE</label>
     </div>

    <div class="input">
      <label for="">Campo ID: </label>
      <input type=text name=id><br>
      
      <label for="">Campo Nome: </label>
      <input type=text name=nome><br>
      
      <label for="">Campo Idade: </label>
      <input type=text name=idade><br>
      
      <input type=submit value="Enviar">
    </div>
  </form>

  <form action="form.php" method="post">
      <input type="hidden" name="metodo" value="VALIDACPF">
    <div class="input">
      <h1>Validar CPF</h1>
      <label for="">CPF: </label>
      <input type=text name=cpf><br>
      
      <input type=submit value="Enviar">
    </div>
  </form>
  <style>
    body{
      width: 100%;
    }
    form{
      width: 350px;
      text-align: left;
      margin: auto;
    }
    .radio{
      padding: 8px;
      font-weight: 600;
      box-shadow: 0px 0px 1px 0px black;
      border-radius: 6px;
    }
    .input{
      padding:30px 10px;
      box-shadow: 0px 0px 1px 0px black;
      border-radius: 6px;
    }
    .input label,
    .input input{
      margin-bottom: 15px;
    }
    .input input,
    .input input:focus-visible
    {
      border: none;
      border-bottom: 1px solid grey;
      outline: none;
    }
    .input input:focus{
      border-bottom: 1px solid black;
    }
    .radio label{
      padding: 5px;
      border-radius: 5px;
    }
    input[type=radio]:checked + label{ 
      background: green;
      color: white;
      padding: 5px;
      border-radius: 5px;
      transition: 0.3s
    }
    input[type=submit]{
      padding: 15px 30px;
      background: green;
      color: white;
      font-weight: 600;
      border-radius: 5px;
      cursor: pointer;
    }
  </style>
</body>
</html>