package Seminar5.AdditionalTask;

public class UserMain {
    public static void main(String[] args) {
        UserModel model = new UserModel();
        UserView view = new UserView();
        UserPresenter presenter = new UserPresenter(model, view);
        String operation = view.getOperation();
        presenter.performeUserOperation(operation);
    }

}
