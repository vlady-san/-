public class ReadyForPay implements IState {
    private String warning="Внесите указанную сумму";
    @Override
    public void print(MachineForPrinting context) {
        System.out.println(warning);
    }

    @Override
    public void selectDoc(MachineForPrinting context, String doc) {
        //печатать будем по одному документу, можно только изменить выбранный документ
        System.out.println("Вы изменили документ на: "+doc);
        context.setDocument(doc);
        context.setState(new ReadyForPay());
    }

    @Override
    public void selectDevice(MachineForPrinting context, String device) {
        System.out.println("Вы изменили устройство на: "+device);
        context.setDevice(device);
        context.setState(new ReadyForSelDoc());
    }

    @Override
    public void toPay(MachineForPrinting context, int money) {
        context.setMoney(context.getMoney()+money);
        System.out.println("Вы внесли: "+money);
        if (/*внесли достаточно денег для печати выбранного документа*/true)
            context.setState(new ReadyForPrint());
        else {
            System.out.println("Недостаточно средств");
            context.setState(this);
        }
    }

    @Override
    public Integer getChange(MachineForPrinting context) {
        return null;
    }
}
