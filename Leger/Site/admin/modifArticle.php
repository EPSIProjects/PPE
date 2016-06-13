<?php
$title="??";

htmlentities('azéoràèndjùd', ENT_COMPAT, 'UTF-8');

include("../header.php");

$libelle_Article = $_POST['lbArticle0'];
$stock_Article = $_POST['stkArticle0'];

foreach($_POST as $art)
{
    echo $art . '<br />';
}

include '../footer.php';
?>