package Seminar5.AdditionalTask;

public class UserPresenter {
    private UserView view;
    private UserModel model;

    public UserPresenter(UserModel model, UserView view) {
        this.model = model;
        this.view = view;
    }

    public void performeUserOperation(String operation) {
        switch (operation) {
            case "1":
                model.registration();
                break;
            case "2":
                model.entrance();
                break;
            case "3":
                model.changePassword();
                break;
            case "4":
                model.getResult();
                break;
            default:
                System.out.println("Некорректная операция!");
        }
    }
}
