<?php $title="Veuillez patienter";
function redir()
{
   return "http://" . $_SERVER["SERVER_NAME"] . $_SERVER["REQUEST_URI"];
}

if(redir() == "http://localhost/PPE/Leger/Site/")
{
   header("Location: http://localhost/PPE/Leger/Site/accueil/");
}
elseif(redir() == "http://para-vent.franceserv.com/")
{
   header("Location: http://para-vent.franceserv.com/accueil/");
}
else
{
   header("Location: http://para-vent.franceserv.com/accueil/");
}
?>