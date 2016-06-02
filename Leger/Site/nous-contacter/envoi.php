<?php // récupération des variables
// donné un autre nom au variable pour évité les problèmes avec Register Global à ON
$formNom = $_POST['nom'];
$formMail = $_POST['mail'];
$formCom = $_POST['message'];
// pour éviter des erreurs de Notice dans le cas ou le champs est resté vide, on aurait pu mettre !
// $formMail = (!isset($_POST['mail']))?$_POST['mail']:'none';
// Dans le cas ou les variables sont destiné à allimenter un base de donné il faut toujours valider les valeurs pour éviter les problèmes d'injection ! cf Google
//En règle général on traite les variables avec les fonctions htmlentities, mysql_escape_string(),addslash() ...
// Dans l'exemple on va juste vérifier que le nom, le prenom et le mail soit pas vide.
if(!empty($formMail) && !empty($formNom) && !empty($formCom) ){
  //ok pas vide //on convertie les caractètres HTML du commentaire
 $formComm = htmlentities($formCom);
 
 
  //mise en forme du mail
  $message = "$formNom vous a envoyé le message : $formCom.
 Son adresse mail est : $formMail";
 
  if( mail('paravent127@gmail.com',"Demande de contacte","$message") )
   
  {

 $title="Message envoyé !";
include '../header.php';
echo "Votre message a bien été envoyé, nos équipes vous contacteront dés que possible.";

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