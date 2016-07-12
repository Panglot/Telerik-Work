namespace PathOfTheWarrior.WPF
{
    using System;
    using System.Windows;
    using System.Windows.Media.Imaging;
    using Pages;
    using Characters;
    using Items;
    using Skills;    
    /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
    public partial class MainWindow : Window
    {
        StartPage startPage = new StartPage();
        HeroSelect heroSelect = new HeroSelect();
        ArmorSelect armorSelect = new ArmorSelect();
        SkillSelect skillSelect = new SkillSelect();
        Hero myHero = new Hero(30);
        Weapon mainWeapon = new Weapon();
        Armor armor = new Armor();
        Skill skill = new Heal("Heal",25); // heal by default, can be changed when Player picks skill

        public MainWindow()
        {
            InitializeComponent();
            ApplyEventHandlers();
        }



        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(heroSelect);

        }

        private void Swordsman_Click(object sender, RoutedEventArgs e)
        {
            myHero.Avatar = new BitmapImage(new Uri("../Images/swordsman.png", UriKind.RelativeOrAbsolute));
            mainWeapon.Avatar = new BitmapImage(new Uri("../Images/sword.png", UriKind.RelativeOrAbsolute));
            mainWeapon.BonusDamage = 70;
            mainWeapon.AddDamage(myHero);
            mainFrame.NavigationService.Navigate(armorSelect);

        }

        private void Spearman_Click(object sender, RoutedEventArgs e)
        {
            myHero.Avatar = new BitmapImage(new Uri("../Images/spearman.png", UriKind.RelativeOrAbsolute));
            mainWeapon.Avatar = new BitmapImage(new Uri("../Images/spear.png", UriKind.RelativeOrAbsolute));
            mainWeapon.BonusDamage = 45;
            mainWeapon.AddDamage(myHero);
            mainFrame.NavigationService.Navigate(armorSelect);

        }

        private void Archer_Click(object sender, RoutedEventArgs e)
        {
            myHero.Avatar = new BitmapImage(new Uri("../Images/archer.png", UriKind.RelativeOrAbsolute));
            mainWeapon.Avatar = new BitmapImage(new Uri("../Images/bow.png", UriKind.RelativeOrAbsolute));
            mainWeapon.BonusDamage = 100;
            mainWeapon.AddDamage(myHero);
            mainFrame.NavigationService.Navigate(armorSelect);

        }

        private void Light_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("../Images/lightArmor.png", UriKind.RelativeOrAbsolute));
            armor.BonusHealth = 40;
            armor.AddHealth(myHero);
            mainFrame.NavigationService.Navigate(skillSelect);
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("../Images/mediumArmor.png", UriKind.RelativeOrAbsolute));
            armor.BonusHealth = 50;
            armor.AddHealth(myHero);
            mainFrame.NavigationService.Navigate(skillSelect);
        }

        private void Heavy_Click(object sender, RoutedEventArgs e)
        {
            armor.Avatar = new BitmapImage(new Uri("../Images/heavyArmor.png", UriKind.RelativeOrAbsolute));
            armor.BonusHealth = 60;
            armor.AddHealth(myHero);
            mainFrame.NavigationService.Navigate(skillSelect);
        }

        public void Mutilate_Click(object sender, RoutedEventArgs e)
        {
            skill = new Mutilate("Mutilate",50);
            skill.Avatar = new BitmapImage(new Uri("../Images/mutilate.png", UriKind.RelativeOrAbsolute));
            MainMap mainMap = new MainMap(myHero, mainWeapon, armor, skill); 
            mainFrame.NavigationService.Navigate(mainMap);
        }

        public void PrecisionStrike_Click(object sender, RoutedEventArgs e)
        {
            skill = new Mutilate("Mutilate", 60);
            skill.Avatar = new BitmapImage(new Uri("../Images/precisionStrike.png", UriKind.RelativeOrAbsolute));
            MainMap mainMap = new MainMap(myHero, mainWeapon, armor, skill);
            mainFrame.NavigationService.Navigate(mainMap);

        }

        public void Heal_Click(object sender, RoutedEventArgs e)
        {
            skill = new Heal("Heal", 25);
            skill.Avatar = new BitmapImage(new Uri("../Images/heal.png", UriKind.RelativeOrAbsolute));
            MainMap mainMap = new MainMap(myHero, mainWeapon, armor, skill); 
            mainFrame.NavigationService.Navigate(mainMap);
        }

        private void ApplyEventHandlers()
        {
            myHero.Inventory.Add(mainWeapon);
            myHero.Inventory.Add(armor);
            mainFrame.NavigationService.Navigate(startPage);
            startPage.startButton.Click += startButton_Click;
            heroSelect.swordsmanButton.Click += Swordsman_Click;
            heroSelect.spearmanButton.Click += Spearman_Click;
            heroSelect.archerButton.Click += Archer_Click;
            armorSelect.lightButton.Click += Light_Click;
            armorSelect.mediumButton.Click += Medium_Click;
            armorSelect.heavyButton.Click += Heavy_Click;
            skillSelect.mutilateButton.Click += Mutilate_Click;
            skillSelect.healButton.Click += Heal_Click;
            skillSelect.precisionButton.Click += PrecisionStrike_Click;
        }
    }
}
