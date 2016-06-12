<?php
    $formNom = $_POST['nom'];
    $formMail = $_POST['mail'];
    $formTel = $_POST['tel'];
    $formArt = $_POST['combobox'];


    if (!preg_match("#^[a-z0-9._-]+@(hotmail|live|msn).[a-z]{2,4}$#", $formMail))
    {
        $passage_ligne = "\r\n";
    }

    else
    {
        $passage_ligne = "\n";
    }

    //=====Définition du sujet.
    $sujet = "Réservation équipement!";
    //=========

    //=====Création du message.
    $message = '$formNom souhaite réserver l\'article $formArt
     L\'email est : $formMail
     Le numéro de téléphone : $formTel';

    //=====Envoi de l'e-mail.
    mail('paravent127@gmail.com', $sujet, $message);
    //==========
?>