namespace Les_énumérations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { Prenom = "John", Nom = "Doe", Couleurs = ECouleurs.ROUGE },
                new User { Prenom = "Anne", Nom = "Dupont", Couleurs = ECouleurs.BLEU },
                new User { Prenom = "Alice", Nom = "Petit", Couleurs = ECouleurs.VERT },
                new User { Prenom = "Siwar", Nom = "Said", Couleurs = ECouleurs.JAUNE },
                new User { Prenom = "Alex", Nom = "Davis", Couleurs = ECouleurs.ROUGE }
            };
            foreach (var user in users)
            {
                Console.WriteLine($"Prénom : {user.Prenom}");
                Console.WriteLine($"Nom : {user.Nom}");
                Console.WriteLine($"Couleur : {user.Couleurs}");
                Console.WriteLine();
            }
            foreach (ECouleurs c in Enum.GetValues(typeof(ECouleurs)))
            {
                int count = users.Count(u => u.Couleurs == c);
                Console.WriteLine($"{c.GetDescription()} : {count} utilisateurs");
            }
        }


    }
}
