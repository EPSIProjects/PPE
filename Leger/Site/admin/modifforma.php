<?php
$title="??";

htmlentities('azéoràèndjùd', ENT_COMPAT, 'UTF-8');

include("../header.php");

$libelle_Forma = $_POST['lbforma0'];

foreach($_POST as $lib)
{
    echo $lib . '<br />';
}

include '../footer.php';
?>