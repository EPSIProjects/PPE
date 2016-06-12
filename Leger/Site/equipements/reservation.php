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
    $message_txt = "Message";

    //=====Création de la boundary
    $boundary = "-----=".md5(rand());
    //==========

    //=====Définition du sujet.
    $sujet = "Réservation équipement!";
    //=========

    //=====Création du header de l'e-mail
    $header = "From: \"$formNom\" $formMail".$passage_ligne;
    $header .= "Reply-to: \"paravent127@gmail.com\" <paravent127@gmail.com>".$passage_ligne;
    $header .= "MIME-Version: 1.0".$passage_ligne;
    $header .= "Content-Type: multipart/alternative;".$passage_ligne." boundary=\"$boundary\"".$passage_ligne;
    //==========

    //=====Création du message.
    //$message = $passage_ligne."--".$boundary.$passage_ligne;
    $message = "$formNom souhaite réserver l'article $formArt
     L'email est : $formMail
     Le numéro de téléphone : $formTel";


    //=====Ajout du message au format texte.
    $message.= "Content-Type: text/plain; charset=\"ISO-8859-1\"".$passage_ligne;
    $message.= "Content-Transfer-Encoding: 8bit".$passage_ligne;
    $message.= $passage_ligne.$message_txt.$passage_ligne;
    //==========


    $message.= $passage_ligne."--".$boundary."--".$passage_ligne;
    $message.= $passage_ligne."--".$boundary."--".$passage_ligne;
    //==========


    //=====Envoi de l'e-mail.
    mail($formMail, $sujet, $message,$header);
    //==========
?>