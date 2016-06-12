<?php
$title="??";

htmlentities('azéoràèndjùd', ENT_COMPAT, 'UTF-8');

include("../header.php");

$libelle_Article = $_POST['lbArticle'];

echo ('L\'article : '.$libelle_Article.' a bien été modifié.');

include '../footer.php';
?>