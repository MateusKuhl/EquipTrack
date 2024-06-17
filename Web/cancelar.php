<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cancelar</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.1/css/all.css" integrity="sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP" crossorigin="anonymous">

    <link rel="stylesheet" href="reservar.css">

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inconsolata:wght@200..900&display=swap" rel="stylesheet">

</head>
<body>

    <div class="wrapper">
        <div class="form">
            <h1 class="title">CANCELAR</h1>
   
            <form method="post" action="./post_cancelar.php" enctype="multipart/form-data" class="myform">
                <div class="full-width">
                    <label for="nome">NOME *</label>
                    <input type="text" id="nome" name="nomeC" value="" required>
                </div>
   
                <div class="full-width">
                    <label for="acessorios">ACESSORIO *</label>
                    <select id="acessorios" name="acessoriosC" required>
                        <?php
                            include "./options_reserva.php";
                        ?>
                      </select>
                </div>
   
                <div class="control-from">
                    <label for="bloco">BLOCO *</label>
                    <input type="number" id="bloco" name="blocoC" value="" placeholder="01" required>
                </div>
   
                <div class="control-from">
                    <label for="sala">SALA *</label>
                    <input type="number" id="sala" name="salaC" value="" placeholder="01" required>
                </div>
   
                <div class="control-from">
                    <label for="data">DATA *</label>
                    <input type="date" id="data" name="dataC" value="" required>
                </div>
   
                <div class="control-from">
                    <label for="hora">HORARIO *
                    </label>
                    <input type="time" id="hora" name="horaC" value="" required>
                </div>
   
                <div class="button">
                    <button id="register">CANCELAR</button>
                </div>

                <div class="button">
                    <button id="cancel" type="submit" formaction="menu.html" formnovalidate>VOLTAR</button>
                </div>
   
            </form>
        </div>
    </div>
    
</body>
</html>