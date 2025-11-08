using UnityEngine;

public class InputSystem : MonoBehaviour
{
    [Header("Overlay")]
    [Range(0.8f, 3f)]
    public float uiScale = 1.8f;      // общий масштаб оверлея
    public bool showOverlay = true;   // можно выключать при необходимости

    // Панели
    public bool AdminPanel { get; private set; }
    public bool StaffPanel { get; private set; }
    public bool ManagerPanel { get; private set; }
    public bool MainPanel { get; private set; }
    public bool InfoTabPanel { get; private set; }
    public bool DishesPanel { get; private set; }
    public bool HookahPanel { get; private set; }
    public bool ReservationPanel { get; private set; }
    public bool NewsPanel { get; private set; }

    private void Update()
    {
        // Ваши хоткеи
        AdminPanel = Input.GetKeyDown(KeyCode.A);
        StaffPanel = Input.GetKeyDown(KeyCode.S);
        ManagerPanel = Input.GetKeyDown(KeyCode.M);
        MainPanel = Input.GetKeyDown(KeyCode.Space);
        InfoTabPanel = Input.GetKeyDown(KeyCode.I);
        DishesPanel = Input.GetKeyDown(KeyCode.D);
        HookahPanel = Input.GetKeyDown(KeyCode.H);
        ReservationPanel = Input.GetKeyDown(KeyCode.R);
        NewsPanel = Input.GetKeyDown(KeyCode.N);

        // Быстрая регулировка размера оверлея
        if (Input.GetKey(KeyCode.Equals) || Input.GetKey(KeyCode.KeypadPlus)) uiScale = Mathf.Min(3f, uiScale + 0.1f);
        if (Input.GetKey(KeyCode.Minus) || Input.GetKey(KeyCode.KeypadMinus)) uiScale = Mathf.Max(0.8f, uiScale - 0.1f);
    }

    private void OnGUI()
    {
        if (!showOverlay) return;

        // Базовые размеры (до масштабирования)
        float panelWidth = 320f;
        float lineHeight = 30f;
        float margin = 12f;
        float padding = 12f;

        // Применяем масштаб и якорим к правому верхнему углу
        float scaledWidth = panelWidth * uiScale;
        Matrix4x4 old = GUI.matrix;
        GUI.matrix = Matrix4x4.TRS(
            new Vector3(Screen.width - scaledWidth - margin, margin, 0),
            Quaternion.identity,
            new Vector3(uiScale, uiScale, 1f)
        );

        // Фон-рамка
        Color oldColor = GUI.color;
        GUI.color = new Color(0f, 0f, 0f, 0.45f);
        GUI.Box(new Rect(0, 0, panelWidth, 10 * lineHeight + padding * 2 + 8f), GUIContent.none);
        GUI.color = oldColor;

        // Заголовок
        var title = new GUIStyle(GUI.skin.label)
        {
            fontSize = 20,
            fontStyle = FontStyle.Bold,
            alignment = TextAnchor.UpperRight,
            normal = { textColor = Color.white }
        };
        DrawShadowLabel(new Rect(padding, padding - 2, panelWidth - padding * 2, lineHeight), "Управление", title);

        // Стиль строк
        var row = new GUIStyle(GUI.skin.label)
        {
            fontSize = 18,
            alignment = TextAnchor.UpperRight,
            normal = { textColor = Color.white }
        };

        float y = padding + lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Admin Panel      →  [A]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Staff Panel      →  [S]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Manager Panel    →  [M]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Main Panel       →  [Space]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Info Tab         →  [I]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Dishes           →  [D]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Hookah           →  [H]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "Reservation      →  [R]", row); y += lineHeight;
        DrawShadowLabel(new Rect(padding, y, panelWidth - padding * 2, lineHeight), "News             →  [N]", row);

        // Восстанавливаем матрицу GUI
        GUI.matrix = old;
    }

    /// <summary>Рисует текст с небольшой тенью для читаемости.</summary>
    private void DrawShadowLabel(Rect r, string text, GUIStyle style)
    {
        var shadow = new GUIStyle(style);
        shadow.normal.textColor = new Color(0f, 0f, 0f, 0.8f);
        Rect s = new Rect(r.x + 1f, r.y + 1.5f, r.width, r.height);
        GUI.Label(s, text, shadow);
        GUI.Label(r, text, style);
    }
}