<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Alterar</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.1/css/all.css" integrity="sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP" crossorigin="anonymous">

    <link rel="stylesheet" href="consultar.css">

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inconsolata:wght@200..900&display=swap" rel="stylesheet">
</head>
<body>

    <div class="wrapper">
        <div class="form">
            <h1 class="title">CONSULTAR</h1>
            <h2 class="desc">Escolha os filtros para consulta</h2>

            <form class="myform" onsubmit="enviaPHP(event)">
                <div class="full-width">
                    <label for="nome">NOME</label>
                    <input type="text" id="nome" name="nomeV" value="">
                </div>

                <div class="full-width">
                    <label for="acessorios">ACESSORIO</label>
                    <select id="acessorios" name="acessoriosV">
                        <?php include "./options_reserva.php"; ?>
                    </select>
                </div>

                <div class="control-from">
                    <label for="bloco">BLOCO</label>
                    <input type="number" id="bloco" name="blocoV" value="" placeholder="01">
                </div>

                <div class="control-from">
                    <label for="sala">SALA</label>
                    <input type="number" id="sala" name="salaV" value="" placeholder="01">
                </div>

                <div class="control-from">
                    <label for="data">DATA</label>
                    <input type="date" id="data" name="dataV" value="">
                </div>

                <div class="control-from">
                    <label for="hora">HORARIO</label>
                    <input type="time" id="hora" name="horaV" value="">
                </div>

                <div class="button">
                    <button id="register" type="submit">CONSULTAR</button>
                </div>

                <div class="button">
                    <button id="cancel" type="button" onclick="window.location.href='menu.html'">VOLTAR</button>
                </div>
            </form>

            <div class="return" id="retornoPost"></div>
        </div>
    </div>

    <script>
        function enviaPHP(event) {
            // Prevenção do comportamento padrão do formulário
            event.preventDefault();

            // Exibindo o valor do campo data no console para verificar se está sendo capturado corretamente
            console.log($('#data').val());

            // Fazendo a requisição POST para o arquivo PHP
            $.post("./post_consultar.php", 
            { 
                nomeV: $('#nome').val(), 
                acessoriosV: $('#acessorios').val(), 
                blocoV: $('#bloco').val(), 
                salaV: $('#sala').val(), 
                dataV: $('#data').val(), 
                horaV: $('#hora').val() 
            })
            .done(function(data) {
                // Inserindo a resposta do PHP no elemento com id 'retornoPost'
                $('#retornoPost').html(data);
            })
            .fail(function(jqXHR, textStatus, errorThrown) {
                // Tratando erros da requisição
                console.error('Erro na requisição:', textStatus, errorThrown);
                $('#retornoPost').html('Erro na consulta. Por favor, tente novamente.');
            });
        }
    </script>
</body>
</html>
