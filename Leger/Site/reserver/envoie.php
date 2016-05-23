<?php
$formNom = $_POST['nom'];
$formMail = $_POST['mail'];
$formCom = $_POST['message'];
$formTyp = $_POST['type'];
$formPer = $_POST['periode'];
$formTel = $_POST['tel'];
if(!empty($formMail) && !empty($formNom) && !empty($formCom) && !empty($formTyp) && !empty($formPer) ){
 $formComm = htmlentities($formCom);
 
 
  //mise en forme du mail
  $message = "$formNom souhaite effectuer une formation de $formTyp durant la période de formation : $formPer.
 Voici son message : $formCom
 Son adresse mail est : $formMail
 Ainsi que son numéro de contact: $formTel";
 
  if( mail('paravent127@gmail.com',"Demande de formation","$message") )
   
  {
 $title="Message envoyé !";
include '../header.php';
echo "Votre demande a bien été prise en compte, nos équipes vous contacteront dés que possible.";

include '../footer.php';
  }
  else{
 $title="Erreur";
include '../header.php';
echo "Une erreur s'est produite, veuillez réessayer";

include '../footer.php';
  }
}
  else{
 $title="Erreur";
include '../header.php';
echo "Une erreur s'est produite, veuillez réessayer";

include '../footer.php';
}

?>