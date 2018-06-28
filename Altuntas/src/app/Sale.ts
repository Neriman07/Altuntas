import { Seller } from './Seller';
import { Buyer } from './Buyer'; 

export class Sale {
  public id: number;
  public sellerId: number;
  public seller: Seller;
  public buyerId: number;
  public buyer:Buyer;
  public address: string;
  public width: number;

  public height: number;

  public length: number;

  public recievedtForms: string;
  
  public warantyEndDate: Date;


  public invoicaPrice: number;

  public ourSalePrice: number;

  public commission: number;

  public extraFormPrice: string;

  public description: string;

  public createDate: Date;

  public createBy: string;

  public updateDate: Date;

  public updateBy: string;
}
