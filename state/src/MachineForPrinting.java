public class MachineForPrinting {

    private String device;
    private String document;
    private IState state;
    private int money;

    public MachineForPrinting()
    {
        state=new InitState();
        money=0;
    }

    public void print() {
        state.print(this);
    }

    public void selectDoc(String doc) {
        state.selectDoc(this, doc);
    }

    public void selectDevice(String device) {
        state.selectDevice(this, device);
    }

    public void toPay(int money) {
        state.toPay(this, money);
    }




    public void setDevice(String device) {
        this.device = device;
    }

    public void setDocument(String document) {
        this.document = document;
    }

    public void setMoney(int money) {
        this.money = money;
    }

    public void setState(IState state) {
        this.state = state;
    }

    public String getDevice() {
        return device;
    }

    public int getMoney() {
        return money;
    }

    public IState getState() {
        return state;
    }

    public String getDocument() {
        return document;
    }


}
