using ClassesApp;
using System;

namespace Data
{
    public class Stub : Chargeur
    {
        /// <summary>
        /// Méthode chargeant des données préconçues
        /// </summary>
        /// <param name="chemin">paramètre inutilisé mais nécessaire</param>
        /// <returns name="stock">Ensemble de données préconçues</returns>
        public override StockageApp Charger(string chemin)
        {

            /// Stockage application :

            StockageApp stock = new StockageApp();
           
            /// Boite de jeu :

            BoiteDeJeu b1 = new BoiteDeJeu("La boite de jeu contient tout le nécessaire pour vous lancer à l’aventure avec vos amis ou votre famille !", "Amazon.fr", "Initiation au jeu d'aventure", "\\Images;Component\\BoiteDeJeu\\boiteDeJeuInitationAventure.png");
            BoiteDeJeu b2 = new BoiteDeJeu("Description de la boite 2", "Amazon.fr", "Nom de la boite 2", "\\Images;Component\\BoiteDeJeu\\boiteDeJeuInitationAventureVengeance.png");
            BoiteDeJeu b3 = new BoiteDeJeu("Description de la boite 3", "Amazon.fr", "Nom de la boite 3", "\\Images;Component\\BoiteDeJeu\\boiteDeJeuCthulhu.png");
            stock.AjoutBoite(b1);
            stock.AjoutBoite(b2);
            stock.AjoutBoite(b3);


            /// ARQUEBUSIER :

            Compétence c1 = new Compétence("l’arquebusier obtient un  bonus  de  +1  par  Rang  dans  cette  voie  à  tous  les  tests  visant  à  réparer  ou  à   comprendre   des   mécanismes   (cela   inclus  le  fait  de  désamorcer  des  pièges  mécaniques  et  de  manipuler  des  armes  de  siège).  Il  peut  appliquer  ce  bonus  à  tous les tests d’attaque avec des armes de siège (baliste, couleuvrine, canon, trébu-chet, catapulte, etc.).", "Mécanisme");
            Compétence c2 = new Compétence("après avoir  raté  une  attaque  à  distance  au  tour  précédent,  l’arquebusier  déclare  qu’il  s’agissait  d’un  tir  de  semonce.  À  ce  tour,  il  tire  sur  la  même  cible  et  obtient +5 à son test et +1d6 aux DM sur sa première attaque.", "Tir de semonce");
            Compétence c3 = new Compétence("l’arquebu-sier  met  en  joue  une  cible  sur  laquelle  il  a  l’initiative  et  attend.  Si  elle  se  dé-place  à  ce  tour,  il  effectue  une  attaque  à distance. En cas de succès la victime choisit entre deux possibilités : soit elle subit  double  dégâts,  soit  elle  ne  se  dé-place pas et ne subit pas de dégâts, tout en perdant son tour.", "Tir de barrage");
            Compétence c4 = new Compétence("l’arquebusier obtient  une  couleuvrine,  un  petit  canon  portatif  qui  nécessite  la  mise  en  place  d’un  trépied  (ou  d’un  appui).  Utiliser  cette  arme  demande  une  action  limitée  et ne peut avoir lieu qu’une seule fois par combat. Sur un test d’attaque à distance réussi, elle inflige [4d6 + Mod. de DEX] DM.  La  portée  maximale  de  cette  arme  est de 100 mètres et sa portée minimale de 10 mètres.", "Couleuvrine");
            Compétence c5 = new Compétence(" lorsqu’il utilise le Tir de barrage, l’arquebusier peut affecter jusqu’à [1 + Mod. de DEX] cibles  dif-férentes dans le même tour. Toutes les cibles doivent être dans une zone fron-tale  de  20  mètres  de  large  au  maximum.  Chaque  cible  donne  lieu  à  un  test d’attaque à distance indépendant.", "Feu nourri");

            Compétence c6 = new Compétence(" l’arquebusier  sait  fa-briquer  sa  propre  poudre  et  d’autres  substances  explosives,  et  obtient  un  bonus de +2 par Rang à tous les tests de  chimie  ou  d’alchimie.  Les  armes  à  poudre  du  personnage  ne  présentent  plus de risque de « faire long feu » ou d’explosion  et  le  joueur  ne  lance  plus  de « dé de poudre ».", "Chimiste");
            Compétence c7 = new Compétence("l’arquebusier   peut   préparer un explosif qui lui permet de dé-molir facilement des structures. Il lui faut 3  tours  complets  pour  préparer  et  poser  son  explosif.  Celui-ci  inflige à  la  struc-ture  2d6  DM  par  Rang  dans  la  voie  et  1d6 par rang dans un rayon de 6 mètres autour (en ignorant la moitié de la RD de la structure. Voir « DM aux structures »).", "Démolition");
            Compétence c8 = new Compétence(" l’arque-busier   sait   préparer   lui-même   une   poudre  plus  puissante,  il  ajoute  +10  mètres à la portée et +2 aux dégâts de toutes ses armes à poudre.", "Poudre puissante");
            Compétence c9 = new Compétence(" il  faut  un  tour  complet   à   l’arquebusier   pour   installer   un  piège  qui  explose  dans  un  rayon  de  3  mètres en infligeant 5d6 DM (test de DEX difficulté 15 pour ne subir que la moitié des DM). L’arquebusier peut choisir entre deux  modes  de  déclenchement,  soit  avec  un  retardateur  allant  de  1  à  10  tours  au  choix,  soit  à  l’intrusion  de  toute  créature  dans une zone d’1 mètre autour du piège. Cette seconde solution demande 1 tour de préparation  supplémentaire  et  un  per-sonnage attentif peut détecter et éviter le piège avec un test de SAG difficulté [12 + Mod. d’INT de l’arquebusier].", "Piège explosif");
            Compétence c10 = new Compétence("l’arquebusier sait  fabriquer  et  lancer  de  petites  boules  de  métal  munies  de  poudre  et  d’une mèche.  Un  tel  projectile  a  une  por-tée  de  20  mètres  et  explose  dans  un  rayon de 5 mètres en infligeant 5d6 DM, divisé par 2 pour les victimes qui réussissent un test de DEX difficulté [12 + Mod. de DEX de l’arquebusier].", "Boulet explosif");

            Compétence c11 = new Compétence("une fois par tour,   l’arquebusier   peut   échanger   son  initiative  avec  un  autre  person-nage  volontaire.  S’il  cède  son  Ini-tiative  à  un  personnage  plus  lent,  il  gagne  un  bonus  de  +1  sur  ses  tests  d’attaque à ce tour. Ce bonus passe à +2 au Rang 4 de la voie.", "Action concertée");
            Compétence c12 = new Compétence("jusqu’à  son  prochain  tour,  l’arquebusier  divise  par  2  les  DM  dus  aux  attaques  à  distance  et  de  zone  qu’il  reçoit,  et  peut  se  déplacer  de  20  mètres.  Un  compagnon  de  l’arquebusier  peut  profiter de cette aptitude s’il a son accord et reste à son contact", "À couvert");
            Compétence c13 = new Compétence(" l’ar-quebusier   peut   choisir   n’importe   quelle  capacité  de  rang  2  d’une  voie  de  guerrier  de  son  choix  et  gagne  3  PV  supplémentaires.  Il  peut  choisir  une capacité de Rang 1 seulement et gagne alors 6 PV au lieu de 3.", "Combattant aguerri");
            Compétence c14 = new Compétence("l’arque-busier obtient une action de mou-vement  ou  une  action  d’attaque  supplémentaire  à  chaque  tour  si  le  combat  implique  au  moins  10  créatures (en comptant l’arquebu-sier et ses alliés)", "Combat de masse");
            Compétence c15 = new Compétence("l’arquebusier  augmente  son  score  de  CON  de  +2  et  il  peut  désormais  lancer deux d20 à chaque fois qu’un test  de  CON  lui  est  demandé  et  conserver le meilleur résultat", "Constitution héroïque");

            Compétence c16 = new Compétence(" si son arme à poudre est prête (char-gée  et  tenue  en  main),  l’arquebu-sier  peut  tirer  avec  un  bonus  de  +10 à son Initiative", "Plus vite que son ombre");
            Compétence c17 = new Compétence(" recharger une pétoire ou un mousquet devient une action  de  mouvement.  Dans  le  cas  d’une  arbalète  de  poing  ou  d’une  arbalète    légère,    l’action    devient    gratuite. À partir du Rang 5 dans la voie,  il  peut  recharger  deux  armes  en une seule action.", "Cadence de tir");
            Compétence c18 = new Compétence("l’arquebu-sier  est  capable  de  tirer  avec  une  pétoire   dans   chaque   main   sans   pénalité.  Si  l’arquebusier  décharge  simultanément ses deux armes sur la même cible, il fait un seul test à +2 en attaque (mais il lance séparé-ment les DM). Le joueur peut choi-sir  de  ne  pas  réaliser  les  deux  tirs  simultanément, afin, par exemple, de pouvoir tirer sur une autre cible s’il  tue  la  première.  Dans  ce  cas,  il  n’obtient pas de bonus en attaque. ", "Tir double");
            Compétence c19 = new Compétence(" lorsqu’il atteint une DEF de 25 ou plus sur son  attaque  à  distance  avec  une  arme  à  poudre  ou  une  arbalète,  l’arquebusier ajoute +1d6 aux DM de son attaque", "As de la gâchette");
            Compétence c20 = new Compétence(" l’arque-busier augmente son score de DEX de  +2  et  il  peut  désormais  lancer  deux d20 à chaque fois qu’un test de DEX  lui  est  demandé,  et  conserver  le meilleur résultat", "Dextérité héroïque");

            Compétence c21 = new Compétence(" l’arquebusier ignore    les  pénalités  normalement  appliquées  lorsque  la  cible  est  à  couvert (généralement -2 à -5)", "Joli coup");
            Compétence c22 = new Compétence("l’arquebusier   ajoute un bonus de +1 aux DM des armes  de  tir  jusqu’à  une  portée  de  [5 x Mod. de DEX]. Ce bonus passe à +2 au Rang 4 de la voie.", "Tir précis");
            Compétence c23 = new Compétence("l’arquebusier  passe  un  tour  complet  à  analyser  le  point  faible  de  son  ad-versaire et à viser. Au tour suivant, il réalisera  ses  attaques  à  distance  sur  cette  cible  contre  une  DEF  de  [10  +  Mod. de DEX de la cible]. Au lieu de ", "Défaut dans la cuirasse");
            Compétence c24 = new Compétence(" l’arquebu-sier est capable de réaliser un tir à longue  distance  sans  pénalité  :  il  double  la  portée  des  armes  à  dis-tance.  Il  peut  aussi  tirer  jusqu’au  triple  de  la  portée  indiquée  avec  une pénalité de -5 en attaque et aux DM. Cette capacité ne modifie pas la portée de Tir précis.", "Tir parabolique");
            Compétence c25 = new Compétence("pour une attaque à    distance,    l’arquebusier    peut    choisir  d’utiliser  un  d12  pour  son  attaque au lieu du d20 habituel (et il  ajoute  normalement  son  score  d’attaque).  Si  l’attaque  est  réussie,  il ajoute +2d6 aux DM.", "Tir mortel");

            Voie v1 = new Voie("Voie de l'artilleur");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);

            Voie v2 = new Voie("Voie des explosifs");
            v2.AjoutCompétence(c6);
            v2.AjoutCompétence(c7);
            v2.AjoutCompétence(c8);
            v2.AjoutCompétence(c9);
            v2.AjoutCompétence(c10);

            Voie v3 = new Voie("Voie du champ de bataille");
            v3.AjoutCompétence(c11);
            v3.AjoutCompétence(c12);
            v3.AjoutCompétence(c13);
            v3.AjoutCompétence(c14);
            v3.AjoutCompétence(c15);

            Voie v4 = new Voie("Voie du pistolero");
            v4.AjoutCompétence(c16);
            v4.AjoutCompétence(c17);
            v4.AjoutCompétence(c18);
            v4.AjoutCompétence(c19);
            v4.AjoutCompétence(c20);

            Voie v5 = new Voie("Voie de la précision");
            v5.AjoutCompétence(c21);
            v5.AjoutCompétence(c22);
            v5.AjoutCompétence(c23);
            v5.AjoutCompétence(c24);
            v5.AjoutCompétence(c25);


            Profil p1 = new Profil("Arquebusier", "1d8", "Pétoire, épée longue, dague, armure de cuir", "armes de contact à une main, armes à distance, armes à poudre, armure jusqu'à la chemise de maille", "divers", "L’arquebusier est un dur à cuir, un soldat ou un mercenaire habitué des champs de bataille. C’est un spécialiste du combat à distance et plus particulièrement des armes à feu et des explosifs.", "\\Images;Component\\Profil\\Arquebusier.PNG");
            p1.AjoutVoie(v1);
            p1.AjoutVoie(v2);
            p1.AjoutVoie(v3);
            p1.AjoutVoie(v4);
            p1.AjoutVoie(v5);
            stock.AjoutProfil(p1);


            ///BARDE : 

            p1 = new Profil("Barde", "1d6", "Rapière (DM 1d6, Crit 19-20), dague (DM 1d4), instrument de musique, armure de cuir (DEF +2).", "Le barde sait manier les armes à 1 main. Il peut porter jusqu’à l’armure de cuir renforcée et ne peut pas manier le bouclier.", "Attaque magique : Mod. de CHA", "Le barde est un personnage polyvalent qui utilise la magie et le spectacle pour divertir et parvenir à ses fins. Il est aussi habitué aux ruses qu’à la diplomatie.", "\\Images;Component\\Profil\\Barde.png");

            c1 = new Compétence("le  barde  peut  utiliser  son   score   d’attaque   à   distance   pour   combattre  au  contact  lorsqu’il  emploie  une arme à une main légère comme une dague, une épée courte ou une rapière", "Précision  ");
            c2 = new Compétence(" le barde  ajoute  son  Mod.  d’INT  en  Ini-tiative et en DEF en plus de son Mod. de DEX", "Intelligence du combat");
            c3 = new Compétence("le barde effectue une attaque fictive pour déséquilibrer son adversaire  et  réaliser  ensuite  une  at-taque mortelle. Faites un test d’attaque normal à ce tour mais n’infligez aucun dégât. Au tour suivant, si vous attaquez le  même  adversaire,  vous  profiterez d’un bonus de +5 en attaque et, si votre feinte était réussie, de +2d6 aux DM.", "Feinte");
            c4 = new Compétence("le style  de  combat  du  barde  est  flam-boyant   et   surprenant   :   avec   cette   Capacité,  il  effectue  une  attaque  de  contact avec un bonus d’attaque et de DM égal à son Mod. de CHA (en plus du Mod. de FOR ou de DEX).", "Attaque flamboyante");
            c5 = new Compétence("lors  d’une  at-taque au contact, s’il obtient un score total  d’attaque  supérieur  ou  égal  à  la  DEF  de  son  adversaire  +10  points,  le  barde  obtient  un  bonus  de  +2d6  aux  DM de son attaque", "Botte mortelle");

            v1 = new Voie("Voie de l’escrime");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);
            p1.AjoutVoie(v1);

            c1 = new Compétence("le  barde  chante  et  inspire  ses  compagnons  :  tous  les  alliés  à  portée  de  voix  ob-tiennent  un  bonus  de  +1  à  tous  leurs  tests pendant [5+ Mod. de CHA] tours.", "Chant des héros");
            c2 = new Compétence("le  barde  pousse un cri dont les effets sont dévas-tateurs (ou produit un son avec un ins-trument à cette même fin). Sur un test d’attaque magique réussi, il inflige [1d6 + Mod. de CHA] DM à toutes les cibles lui faisant face sur une portée de 10 m.", "Attaque sonore");
            c3 = new Compétence(" le  barde  crée  une  zone  de  silence  fixe  de 5   mètres   de   diamètre,   jusqu’à   une   portée  de  30  mètres,  pendant  [1d6+  Mod.  de  CHA]  tours.  Tous  les  sons  émis  dans  cette  sphère  sont  annulés.  La  zone  n’empêche  pas  le  lancement  des sorts mais inflige un malus de -2 à tous les tests d’attaque magique.", "Zone de silence");
            c4 = new Compétence("le barde joue  une  gigue  endiablée  aux  effets  magiques. S’il réussit un test d’attaque magique  contre  la  créature  qu’il  cible,  celle-ci se met à danser pendant [1d4+ Mod. de CHA] tours et subit un malus de -4 aux tests d’attaque et en DEF.", "Danse irrésistible");
            c5 = new Compétence("le barde  joue  de  la  musique  pour  fasci-ner et « contrôler » toutes les créatures de  son  choix  (rats,  gobelins,  humains,  etc.)  dans  un  rayon  de  30  m.  Seules  les  créatures  dont  les  PV  sont  infé-rieurs  ou  égaux  à  [5  +  Mod.  de  CHA]  du   barde   répondent.   Les   créatures   sortent  de  leur  cachette  et  se  dirigent  vers le barde, elles le suivent tant qu’il continue à jouer. Quand il utilise cette capacité  le  barde  peut  également  se  déplacer de 10 m par tour.", "Musique fascinante");

            v1 = new Voie("Voie du musicien");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);
            p1.AjoutVoie(v1);

            c1 = new Compétence(" le  barde  obtient  un  bonus de +2 par rang à tous ses tests de  DEX  visant  à  réaliser  des  acroba-ties, tenir en équilibre, faire des sauts ou de l’escalade.", "Acrobate");
            c2 = new Compétence("le barde ajoute son Mod.  de  CHA  en  DEF  et  en  Initiative  (en plus du Mod. habituel de DEX).", "Grâce féline");
            c3 = new Compétence("une  fois  par tour, en plus de ses autres actions,le  barde  peut  lancer  un  couteau  sur  une cible à distance (maximum 10 m) en réussissant un test d’Attaque à Dis-tance.  Cette  attaque  est  pour  lui  une  action gratuite. Elle occasionne [1d4 + Mod. de DEX] de DM", "Lanceur de couteau");
            c4 = new Compétence("une fois  par  tour,  le  barde  peut  réali-ser  une  esquive  en  réussissant  un  test  d’Attaque  à  Distance  contre  une Difficulté égale au score ob-tenu  par  son  adversaire  lors  de  son attaque. En cas de réussite, le barde ne subit aucun DM. Si cette attaque  était  un  critique,  il  subit  tout  de  même  des  DM  normaux  (et   annule   donc   l’effet   critique   « dégâts doublés »).", "Esquive acrobatique");
            c5 = new Compétence(" le  barde  est  immunisé  à  la  peur  et  à  tous  les  sorts  ou  effets  magiques  qui  asservissent   l’esprit   ou   le   corps   (possession,    charme,    paralysie,    ralentissement, etc.).", "Liberté d'action");

            v1 = new Voie("Voie du saltimbanque");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);
            p1.AjoutVoie(v1);

            c1 = new Compétence("le  barde  obtient  un  bonus  de  +2  par  rang  atteint  dans cette voie pour tous ses tests de CHA visant à séduire, baratiner ou mentir.", "Charmant");
            c2 = new Compétence(" le barde  ne  met  pas  d’armure,  cela  ne  sied  point  en  société.  Sa  seule  armure  est  la  dentelle,  sa  seule  défense, la rapière.Lorsqu’il ne porte aucune armure et combat avec une rapière ou une épée,  le  barde  obtient  un  bonus  de  +1  en  DEF  contre  les  attaques  au contact par Rang possédé dans cette Voie.", "Dentelles et rapière");
            c3 = new Compétence(" une  fois  par  combat,  le  barde  peut  utiliser  un  subterfuge de séducteur pour sur-prendre  et  déstabiliser  un  adver-saire du sexe opposé. Ce peut être un baiser fougueux soudainement délivré  au  coeur  d’une  mêlée,  un  sein qui s’échappe d’un bustier par mégarde, une main qui s’égare par le plus grand des hasards...Il  doit  réussir  un  test  de  CHA  de  difficulté égale à l’INT de son ad-versaire.  En  cas  de  succès  celui-ci  subit  un  malus  de  -10  en  attaque  et en DEF pendant 1 tour.", "Arme secrète");
            c4 = new Compétence("une  fois  par  jour,  le  barde  peut  suggé-rer  une  action  à  une  créature  en  réussissant  un  test  d’at-taque magique avec pour difficulté  les  PV  maxi-mum   de   celle-ci.   En   cas  de  réussite  la  créa-ture   fera   tout   son   possible     pour     satisfaire       sa       demande  pen-dant  24  heures.  Elle évitera les actions suicidaires  (ce  qui  lui  donnerait     immédiate-ment un test d’INT diffi-culté  10  pour  échapper  au sort).", "Suggestion");
            c5 = new Compétence("le   barde   aug-mente            sa            valeur  de  CHA  de  +2.  Il  peut  de  plus lancer deux d20 à  chaque  fois  qu’un  test  de  CHA  lui  est  demandé  et  conserver le meilleur résultat.", "Charisme héroïque");

            v1 = new Voie("Voie de la séduction");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);
            p1.AjoutVoie(v1);
            
            c1 = new Compétence("à   force   de   voyager,   le   barde   a   appris  toutes  sortes  de  choses,  il  obtient  un  bonus  de  +2  par  Rang  dans  cette  voie  aux  tests  d’INT  pour  se  «  souvenir  »  d’une  infor-mation  historique,  politique,  géo-graphique ou occulte qui pourrait lui être utile.", "Rumeurs et légendes");
            c2 = new Compétence("ce  sort  permet  au  barde de lire, écrire et parler n’im-porte  quelle  langue  ancienne  ou  vivante  pendant  [1d6  +  Mod.  de  CHA] minutes.", "Compréhension des langues");
            c3 = new Compétence("le  barde  ob-tient  un  bonus  de  +5  à  tous  ses  tests  de  survie  en  nature  et  aux  tests  de  profession  et  d’artisanat  (forge, charpentier, etc.).", "Débrouillard");
            c4 = new Compétence("ce sort  permet  au  barde  de  prendre  l’apparence   de   n’importe   quelle   créature de taille à peu près équi-valente (avec une marge d’environ 50  cm).  S’il  veut  imiter  une  per-sonne  en  particulier,  il  lui  faudra  réussir un test de CHA difficulté 15  (20  s’il  ne  la  connaît  pas  mais  l’a seulement vue, 10 s’il la connaît très  bien).  Le  sort  a  une  durée  de  10 minutes.", "Déguisement");
            c5 = new Compétence("le barde peut choisir  n’importe  quelle  capacité  de Rang 1 à 3 de son choix au sein d’un autre profil de Chroniques Oubliées.", "Touche à tout");
             
            v1 = new Voie("Voie du vagabond");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);
            p1.AjoutVoie(v1);
            stock.AjoutProfil(p1);

            Profil p3 = new Profil("Nom Profil 3", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p3.AjoutVoie(v1);
            p3.AjoutVoie(v3);
            p3.AjoutVoie(v5);
            stock.AjoutProfil(p3);

            Profil p4 = new Profil("Nom Profil 4", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p4.AjoutVoie(v2);
            p4.AjoutVoie(v3);
            p4.AjoutVoie(v4);
            stock.AjoutProfil(p4);

            /// Utilisateurs

            Utilisateur u1 = new Utilisateur("u1", "azer");
            u1.AjoutProfilFavori(p3);
            stock.AjoutUtilisateur(u1);

            Utilisateur u2 = new Utilisateur("Nom utilisateur 2", "Mot de passe utilisateur 2");
            u2.AjoutProfilFavori(p3);
            u2.AjoutProfilHybride(p4);
            stock.AjoutUtilisateur(u1);

            Utilisateur u3 = new Utilisateur("Nom utilisateur 3", "Mot de passe utilisateur 3");
            u3.AjoutProfilFavori(p1);
            u3.AjoutProfilHybride(p4);
            stock.AjoutUtilisateur(u1);


            return stock;
        }
    }
}
