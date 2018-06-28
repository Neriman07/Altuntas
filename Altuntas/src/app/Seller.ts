import { Sale } from './Sale';

export class Seller {
  public id: number;
  public name: string;
  public logo: string;
  public description: string;
  public sales: Sale[];
}
