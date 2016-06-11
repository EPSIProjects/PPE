-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Sam 11 Juin 2016 à 22:06
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `para-vent`
--

-- --------------------------------------------------------

--
-- Structure de la table `acces`
--

CREATE TABLE IF NOT EXISTS `acces` (
  `id_acces` int(11) NOT NULL AUTO_INCREMENT,
  `numero_acces` int(11) DEFAULT NULL,
  `id_personnel_acces` int(11) NOT NULL,
  PRIMARY KEY (`id_acces`),
  KEY `fk_numacces_personnel` (`id_personnel_acces`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `acces`
--

INSERT INTO `acces` (`id_acces`, `numero_acces`, `id_personnel_acces`) VALUES
(1, 4, 6);

-- --------------------------------------------------------

--
-- Structure de la table `administration`
--

CREATE TABLE IF NOT EXISTS `administration` (
  `affectation_administration` varchar(50) NOT NULL,
  `id_admin` int(11) NOT NULL,
  `id_commande_administration` int(11) NOT NULL,
  KEY `fk_admin_pers` (`id_admin`),
  KEY `fk_admin_commande` (`id_commande_administration`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `administration`
--

INSERT INTO `administration` (`affectation_administration`, `id_admin`, `id_commande_administration`) VALUES
('BORDEAUX', 6, 1);

-- --------------------------------------------------------

--
-- Structure de la table `article`
--

CREATE TABLE IF NOT EXISTS `article` (
  `id_article` int(11) NOT NULL AUTO_INCREMENT,
  `libelle_article` varchar(160) NOT NULL,
  `stock_article` int(100) NOT NULL,
  `id_fournisseur_article` int(11) NOT NULL,
  `prix_article` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id_article`),
  KEY `fk_article_fournisseur` (`id_fournisseur_article`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

--
-- Contenu de la table `article`
--

INSERT INTO `article` (`id_article`, `libelle_article`, `stock_article`, `id_fournisseur_article`, `prix_article`) VALUES
(1, 'Parachute', 5, 1, '199'),
(2, 'Voile', 5, 1, '99'),
(3, 'Casquette', 5, 2, '14'),
(4, 'Lunette', 5, 2, '59'),
(5, 'Casque', 5, 1, '60'),
(6, 'Visière', 5, 2, '35'),
(7, 'Emetteurs recepteurs', 5, 2, '75'),
(8, 'Antenne', 5, 1, '44'),
(9, 'Cockpit', 5, 1, '50'),
(10, 'Cameras', 5, 2, '89'),
(11, 'Ventimètre', 5, 2, '45'),
(12, 'Compas', 5, 1, '7'),
(13, 'GPS', 5, 1, '55'),
(14, 'Sacs classique', 5, 1, '1'),
(15, 'Sacs montagne', 5, 1, '35'),
(16, 'Sellettes', 5, 2, '41'),
(17, 'Blousons', 5, 1, '39'),
(18, 'Pantalons', 5, 1, '24'),
(19, 'Sweats', 5, 2, '30'),
(20, 'Cagoules', 5, 2, '19'),
(21, 'Combinaisons', 5, 2, '84'),
(22, 'Gants', 5, 2, '17'),
(23, 'T-Shirt', 5, 1, '15');

-- --------------------------------------------------------

--
-- Structure de la table `article_neuf`
--

CREATE TABLE IF NOT EXISTS `article_neuf` (
  `id_article_neuf` int(11) NOT NULL,
  KEY `fk_artneuf_art` (`id_article_neuf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `article_occasion`
--

CREATE TABLE IF NOT EXISTS `article_occasion` (
  `id_article_occasion` int(11) NOT NULL,
  KEY `fk_artoccas_art` (`id_article_occasion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `bondecommande_client`
--

CREATE TABLE IF NOT EXISTS `bondecommande_client` (
  `id_bcde_client` int(11) NOT NULL AUTO_INCREMENT,
  `numero_bcde_client` int(10) NOT NULL,
  `date_bcde_client` varchar(50) NOT NULL,
  `id_client_bcde_client` int(9) NOT NULL,
  `prenom_client_bcde_client` varchar(75) NOT NULL,
  `nom_client_bcde_client` varchar(75) NOT NULL,
  `id_commande_bcde_client` int(11) NOT NULL,
  PRIMARY KEY (`id_bcde_client`),
  KEY `fk_bcde_client_client` (`id_client_bcde_client`),
  KEY `fk_bcde_client_commande` (`id_commande_bcde_client`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `bondecommande_fournisseur`
--

CREATE TABLE IF NOT EXISTS `bondecommande_fournisseur` (
  `id_cde_fournisseur` int(11) NOT NULL AUTO_INCREMENT,
  `numero_cde_fournisseur` int(10) NOT NULL,
  `date_cde_fournisseur` varchar(50) NOT NULL,
  `id_commande_bcde_fournisseur` int(11) NOT NULL,
  `id_fournisseur_bcde_fournisseur` int(11) NOT NULL,
  PRIMARY KEY (`id_cde_fournisseur`),
  KEY `fk_bcde_fournisseur_fournisseur` (`id_commande_bcde_fournisseur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `certificat`
--

CREATE TABLE IF NOT EXISTS `certificat` (
  `id_certificat` int(11) NOT NULL,
  `titre_certificat` varchar(150) NOT NULL,
  KEY `fk_certif_formex` (`id_certificat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `id_client` int(9) NOT NULL AUTO_INCREMENT,
  `nom_client` varchar(75) NOT NULL,
  `prenom_client` varchar(75) NOT NULL,
  `adresse_ligne1_client` varchar(255) NOT NULL,
  `mail_client` varchar(200) NOT NULL,
  `adresse_ligne2_client` varchar(250) DEFAULT NULL,
  `code_postal_client` int(6) NOT NULL,
  `ville_client` varchar(100) NOT NULL,
  PRIMARY KEY (`id_client`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `client`
--

INSERT INTO `client` (`id_client`, `nom_client`, `prenom_client`, `adresse_ligne1_client`, `mail_client`, `adresse_ligne2_client`, `code_postal_client`, `ville_client`) VALUES
(1, 'Geron', 'Alexis', '15 rue Craquons', 'alex.geron@gmail.com', NULL, 33200, 'Cenon'),
(2, 'Grimlis', 'Christina', '15 rue de la tourbie', 'christina.trb@orange.fr', NULL, 16520, 'La Jarie'),
(3, 'Paul', 'Doumer', '33 rue du pigeonnnier', 'paul.dou@live.fr', 'résidence alfred P.', 33850, 'Bordeaux'),
(4, 'Lassaiding', 'Ridsa', '99 cour du medoc', 'hanoun@d8.fr', NULL, 45960, 'Ramsay');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE IF NOT EXISTS `commande` (
  `id_commande` int(11) NOT NULL AUTO_INCREMENT,
  `titre_commande` varchar(50) NOT NULL,
  `date_commande` date NOT NULL,
  PRIMARY KEY (`id_commande`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `commande`
--

INSERT INTO `commande` (`id_commande`, `titre_commande`, `date_commande`) VALUES
(1, 'CMDGERON', '2015-12-11');

-- --------------------------------------------------------

--
-- Structure de la table `commerciaux`
--

CREATE TABLE IF NOT EXISTS `commerciaux` (
  `id_commerciaux` int(11) NOT NULL,
  `id_fournisseur_commerciaux` int(11) NOT NULL,
  KEY `fk_commerc_pers` (`id_commerciaux`),
  KEY `fk_commerciaux_fournisseur` (`id_fournisseur_commerciaux`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `formateur`
--

CREATE TABLE IF NOT EXISTS `formateur` (
  `type_formateur` varchar(50) NOT NULL,
  `id_formateur` int(11) NOT NULL,
  KEY `fk_format_pers` (`id_formateur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `formateur`
--

INSERT INTO `formateur` (`type_formateur`, `id_formateur`) VALUES
('Formateur Minier Bordeaux', 13),
('Formateur Brasson Bordeaux', 14),
('Formateur Ramus Bordeaux', 20);

-- --------------------------------------------------------

--
-- Structure de la table `formation`
--

CREATE TABLE IF NOT EXISTS `formation` (
  `id_formation` int(11) NOT NULL AUTO_INCREMENT,
  `libelle_formation` varchar(120) NOT NULL,
  `code_formation` varchar(10) NOT NULL,
  `id_client_formation` int(11) NOT NULL,
  `id_personnel_formation` int(11) NOT NULL,
  `date_debut_formation` date NOT NULL,
  `date_fin_formation` date NOT NULL,
  PRIMARY KEY (`id_formation`),
  KEY `fk_client_form` (`id_client_formation`),
  KEY `fk_formation_personnel` (`id_personnel_formation`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Contenu de la table `formation`
--

INSERT INTO `formation` (`id_formation`, `libelle_formation`, `code_formation`, `id_client_formation`, `id_personnel_formation`, `date_debut_formation`, `date_fin_formation`) VALUES
(1, 'Formation Parapente Amateur Decembre 2015', 'FOPAD15', 1, 14, '2015-12-13', '2015-12-18'),
(2, 'Formation Parapente Amateur Mai 2016', 'FOPAM16', 1, 14, '2016-05-02', '2016-05-06'),
(3, 'Stage Decouverte Debutant S18 Mai 2016', 'SDD18M16', 2, 20, '2016-05-02', '2016-05-06'),
(4, 'Stage Decouverte Debutant S19 Mai 2016', 'SDD19M16', 1, 14, '2016-05-09', '2016-05-13'),
(5, 'Stage Decouverte Debutant S20 Mai 2016', 'SDD20M16', 3, 20, '2016-05-16', '2016-05-20'),
(6, 'Stage Decouverte Debutant S21 Mai 2016', 'SDD21M16', 1, 14, '2016-05-23', '2016-05-27'),
(7, 'Stage Decouverte Debutant S22 Juin 2016', 'SDD22J16', 1, 13, '2016-05-30', '2016-06-03'),
(8, 'Stage Decouverte Debutant S23 Juin 2016', 'SDD23J16', 4, 20, '2016-06-06', '2016-06-10'),
(9, 'Stage Decouverte Debutant S24 Juin 2016', 'SDD24J16', 3, 13, '2016-06-13', '2016-06-17'),
(10, 'Stage Decouverte Debutant S25 Juin 2016', 'SDD25J16', 1, 14, '2016-06-20', '2016-06-24'),
(11, 'Stage Decouverte Debutant S26 Juin 2016', 'SDD26J16', 4, 20, '2016-06-27', '2016-07-01'),
(12, 'Formation Parapente Amateur Juin 2016', 'FOPAJ16', 1, 13, '2016-06-06', '2016-06-10');

-- --------------------------------------------------------

--
-- Structure de la table `form_externe`
--

CREATE TABLE IF NOT EXISTS `form_externe` (
  `id_form_externe` int(11) NOT NULL,
  KEY `fk_formexter_form` (`id_form_externe`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `form_interne`
--

CREATE TABLE IF NOT EXISTS `form_interne` (
  `id_form_interne` int(11) NOT NULL,
  KEY `fk_forminter_form` (`id_form_interne`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `fournisseur`
--

CREATE TABLE IF NOT EXISTS `fournisseur` (
  `id_fournisseur` int(5) NOT NULL AUTO_INCREMENT,
  `nom_fournisseur` varchar(150) NOT NULL,
  `tel_fournisseur` varchar(10) NOT NULL,
  `mail_fournisseur` varchar(100) NOT NULL,
  `type_fournisseur` varchar(50) NOT NULL,
  `adresse_ligne1_fournisseur` varchar(250) NOT NULL,
  `adresse_ligne2_fournisseur` varchar(250) DEFAULT NULL,
  `ville_fournisseur` varchar(100) NOT NULL,
  `codepostal_fournisseur` int(6) NOT NULL,
  `fax_fournisseur` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `fournisseur`
--

INSERT INTO `fournisseur` (`id_fournisseur`, `nom_fournisseur`, `tel_fournisseur`, `mail_fournisseur`, `type_fournisseur`, `adresse_ligne1_fournisseur`, `adresse_ligne2_fournisseur`, `ville_fournisseur`, `codepostal_fournisseur`, `fax_fournisseur`) VALUES
(1, 'BASIK', '0935946735', 'professionnel@basic.fr', 'Materiel', '157 rue Dordan', NULL, 'LE LUC', 83340, '0535946735'),
(2, 'IDCOM', '0946248346', 'vente@idcom.com', 'MATERIEL', '26 rue de Molenbeek', NULL, 'ROYAN', 25460, '0546248346');

-- --------------------------------------------------------

--
-- Structure de la table `hebergement`
--

CREATE TABLE IF NOT EXISTS `hebergement` (
  `id_hebergement` int(3) NOT NULL AUTO_INCREMENT,
  `libelle_hebergement` varchar(150) NOT NULL,
  `place_hebergement` int(3) NOT NULL,
  `lieux_hebergement` varchar(150) NOT NULL,
  `id_formation_hebergement` int(11) NOT NULL,
  PRIMARY KEY (`id_hebergement`),
  KEY `fk_hebergement_formation` (`id_formation_hebergement`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `hebergement`
--

INSERT INTO `hebergement` (`id_hebergement`, `libelle_hebergement`, `place_hebergement`, `lieux_hebergement`, `id_formation_hebergement`) VALUES
(2, 'Chalet Savoie', 9, 'Chambéry', 1);

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

CREATE TABLE IF NOT EXISTS `personnel` (
  `id_personnel` int(11) NOT NULL AUTO_INCREMENT,
  `nom_personnel` varchar(50) NOT NULL,
  `prenom_personnel` varchar(50) NOT NULL,
  `fonction_personnel` varchar(100) NOT NULL,
  `telephone_personnel` varchar(10) NOT NULL,
  `adresse_ligne1_personnel` varchar(200) NOT NULL,
  `code_personnel` int(11) NOT NULL,
  `affectation_personnel` varchar(75) NOT NULL,
  `adresse_ligne2_personnel` varchar(250) DEFAULT NULL,
  `code_postal_personnel` int(6) NOT NULL,
  `ville_personnel` varchar(100) NOT NULL,
  `mot_de_passe_personnel` varchar(30) NOT NULL,
  `identifiant_personnel` varchar(50) NOT NULL,
  `etat` int(1) DEFAULT '0',
  PRIMARY KEY (`id_personnel`),
  UNIQUE KEY `id_personnel` (`id_personnel`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Contenu de la table `personnel`
--

INSERT INTO `personnel` (`id_personnel`, `nom_personnel`, `prenom_personnel`, `fonction_personnel`, `telephone_personnel`, `adresse_ligne1_personnel`, `code_personnel`, `affectation_personnel`, `adresse_ligne2_personnel`, `code_postal_personnel`, `ville_personnel`, `mot_de_passe_personnel`, `identifiant_personnel`, `etat`) VALUES
(1, 'LEMONNIER', 'Marius', 'SI', '650406020', '56 rue du piaf', 36502, 'BORDEAUX', NULL, 40230, 'TYROSSE', 'marius29', 'mariusASR', 0),
(2, 'FOUCHER', 'Benoit', 'SI', '760240415', '26 rue de la berne', 35563, 'BORDEAUX', NULL, 33300, 'BORDEAUX', 'ben', 'ben', 0),
(3, 'EMARD', 'Jean', 'RSI', '650458575', '17 rue Edward Vaillant', 62425, 'BORDEAUX', NULL, 33000, 'BORDEAUX', 'jenmard50', 'jeanRSI', 0),
(4, 'BERTHELLOT', 'Laura', 'SI', '606766777', '52 rue de marseille', 6243246, 'BORDEAUX', NULL, 33000, 'BORDEAUX', 'lberth26', 'lauraSI', 0),
(5, 'PAUCANT', 'Nicolas', 'SI', '0660058574', '69 rue des Glandeur', 69696969, 'BORDEAUX', NULL, 31100, 'SAINT EUGENE', 'caputdraconis', 'nicodures', 0),
(6, 'CASEL', 'Vincent', 'GERANT', '760596212', '153 B rue du puit', 66666, 'BORDEAUX', NULL, 33100, 'BORDEAUX', 'vinc', 'vincadm', 0),
(7, 'PAGNOL', 'Marcel', 'DDS', '536854215', '79 impasse des pigeons', 625625, 'BORDEAUX', NULL, 32560, 'LORMONT', 'marcel', 'marceldds', 0),
(8, 'LEMOINE', 'Sophie', 'DDM', '564585263', '224 rue du loup', 6523056, 'BORDEAUX', NULL, 33600, 'BORDEAUX', 'sophie', 'sophDDM', 0),
(9, 'GRAPHIN', 'Marie', 'DRH', '652354785', '45 rue nicolas', 6482715, 'BORDEAUX', NULL, 35420, 'BORDEAUX', 'marie', 'mariedrh', 0),
(10, 'DURAT', 'Pierre', 'RH', '0685256214', '69 champ de la montagne', 96783125, 'BORDEAUX', 'appartement 005 batiement B5', 34250, 'CENON', 'pierre', 'pierrerh', 0),
(11, 'MONDANT', 'René', 'RH', '0762354589', '35 rue du pommier', 6746513, 'BORDEAUX', 'batiment 3', 32000, 'BRUGES', 'rene', 'renerh', 0),
(12, 'LEGRAND', 'Jordan', 'GDF', '406050501', '26 impasse de la maison blanche', 349871, 'BORDEAUX', NULL, 37560, 'BORDEAUX', 'jordan', 'jordangdf', 0),
(13, 'MINIER', 'François', 'F', '406058535', '05 avenu Taubira', 62465899, 'BORDEAUX', NULL, 33678, 'BORDEAUX', 'francois', 'francois', 0),
(14, 'GRANDU', 'Sophie', 'F', '105062456', '58 impasse de l impossteur', 765235, 'BORDEAUX', 'digicode : 5265', 30000, 'CAVIGNAC', 'sophie', 'sophief', 0),
(15, 'BRASSON', 'Raimonde', 'RSC', '536254859', '54 rue bourbon', 4582645, 'BORDEAUX', NULL, 35200, 'BORDEAUX', 'raimonde', 'raimondersc', 0),
(16, 'BRISSARD', 'Morgane', 'SC', '625854596', '45 rue brisson', 59974313, 'BORDEAUX', NULL, 33000, 'BORDEAUX', 'morgane', 'morganesc', 0),
(17, 'LAGRANDE', 'Laurent', 'C', '564528426', '108 B cours du marne', 18631, 'BORDEAUX', NULL, 35320, 'BORDEAUX', 'd1t5f7g4', 'accesjury', 0),
(18, 'PEREZ', 'Sophie', 'C', '486435427', '207 rue de l''amour', 388462, 'BORDEAUX', NULL, 32000, 'BORDEAUX', '46982', 'sosodd', 0),
(19, 'BERNARD', 'Pascal', 'C', '0506085648', '208 rue Lucien Faure', 876524351, 'CLERMONT-FERRAND', 'Residence des Vins', 96520, 'CLERMONT', 'nanard', 'bebe', 0),
(20, 'RAMUS', 'Leon', 'F', '0765254585', '123 rue edouard Dumont', 6454532, 'BORDEAUX', NULL, 45250, 'Blacart', 'adwaq4', 'mdp4g5', 0);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `acces`
--
ALTER TABLE `acces`
  ADD CONSTRAINT `fk_numacces_personnel` FOREIGN KEY (`id_personnel_acces`) REFERENCES `personnel` (`id_personnel`);

--
-- Contraintes pour la table `administration`
--
ALTER TABLE `administration`
  ADD CONSTRAINT `fk_admin_commande` FOREIGN KEY (`id_commande_administration`) REFERENCES `commande` (`id_commande`),
  ADD CONSTRAINT `fk_admin_pers` FOREIGN KEY (`id_admin`) REFERENCES `personnel` (`id_personnel`);

--
-- Contraintes pour la table `article`
--
ALTER TABLE `article`
  ADD CONSTRAINT `fk_article_fournisseur` FOREIGN KEY (`id_fournisseur_article`) REFERENCES `fournisseur` (`id_fournisseur`);

--
-- Contraintes pour la table `article_neuf`
--
ALTER TABLE `article_neuf`
  ADD CONSTRAINT `fk_artneuf_art` FOREIGN KEY (`id_article_neuf`) REFERENCES `article` (`id_article`);

--
-- Contraintes pour la table `article_occasion`
--
ALTER TABLE `article_occasion`
  ADD CONSTRAINT `fk_artoccas_art` FOREIGN KEY (`id_article_occasion`) REFERENCES `article` (`id_article`);

--
-- Contraintes pour la table `bondecommande_client`
--
ALTER TABLE `bondecommande_client`
  ADD CONSTRAINT `fk_bcde_client_client` FOREIGN KEY (`id_client_bcde_client`) REFERENCES `client` (`id_client`),
  ADD CONSTRAINT `fk_bcde_client_commande` FOREIGN KEY (`id_commande_bcde_client`) REFERENCES `commande` (`id_commande`);

--
-- Contraintes pour la table `bondecommande_fournisseur`
--
ALTER TABLE `bondecommande_fournisseur`
  ADD CONSTRAINT `fk_bcde_fournisseur_commande` FOREIGN KEY (`id_commande_bcde_fournisseur`) REFERENCES `commande` (`id_commande`),
  ADD CONSTRAINT `fk_bcde_fournisseur_fournisseur` FOREIGN KEY (`id_commande_bcde_fournisseur`) REFERENCES `fournisseur` (`id_fournisseur`);

--
-- Contraintes pour la table `certificat`
--
ALTER TABLE `certificat`
  ADD CONSTRAINT `fk_certif_formex` FOREIGN KEY (`id_certificat`) REFERENCES `form_externe` (`id_form_externe`);

--
-- Contraintes pour la table `commerciaux`
--
ALTER TABLE `commerciaux`
  ADD CONSTRAINT `fk_commerciaux_fournisseur` FOREIGN KEY (`id_fournisseur_commerciaux`) REFERENCES `fournisseur` (`id_fournisseur`),
  ADD CONSTRAINT `fk_commerc_pers` FOREIGN KEY (`id_commerciaux`) REFERENCES `personnel` (`id_personnel`);

--
-- Contraintes pour la table `formateur`
--
ALTER TABLE `formateur`
  ADD CONSTRAINT `fk_format_pers` FOREIGN KEY (`id_formateur`) REFERENCES `personnel` (`id_personnel`);

--
-- Contraintes pour la table `formation`
--
ALTER TABLE `formation`
  ADD CONSTRAINT `fk_client_form` FOREIGN KEY (`id_client_formation`) REFERENCES `client` (`id_client`),
  ADD CONSTRAINT `fk_formation_personnel` FOREIGN KEY (`id_personnel_formation`) REFERENCES `personnel` (`id_personnel`);

--
-- Contraintes pour la table `form_externe`
--
ALTER TABLE `form_externe`
  ADD CONSTRAINT `fk_formexter_form` FOREIGN KEY (`id_form_externe`) REFERENCES `formateur` (`id_formateur`);

--
-- Contraintes pour la table `form_interne`
--
ALTER TABLE `form_interne`
  ADD CONSTRAINT `fk_forminter_form` FOREIGN KEY (`id_form_interne`) REFERENCES `formateur` (`id_formateur`);

--
-- Contraintes pour la table `hebergement`
--
ALTER TABLE `hebergement`
  ADD CONSTRAINT `fk_hebergement_formation` FOREIGN KEY (`id_formation_hebergement`) REFERENCES `formation` (`id_formation`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
