export default class AddWalletRequestModel {
    constructor(name: string, startDate: Date, endDate: Date) {
        this.name = name
        this.startDate = startDate
        this.endDate = endDate
    }

    name: string
    startDate: Date
    endDate: Date
}
