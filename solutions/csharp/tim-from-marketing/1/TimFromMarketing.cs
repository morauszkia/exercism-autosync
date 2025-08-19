static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string badgeText = "";
        string formattedDepartment = (department ?? "owner").ToUpper();
        if (id != null)
        {
            badgeText += $"[{id}] - ";
        }
        badgeText += name + " - " + formattedDepartment;
        return badgeText;
    }
}
