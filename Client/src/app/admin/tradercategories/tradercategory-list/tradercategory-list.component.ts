import { Component, OnInit } from '@angular/core';
//import { TradercategoryService } from '../../shared/tradercategory.service';
import { ToastrService } from 'ngx-toastr';
import { TradercategoryService } from 'src/app/shared/tradercategory.service';
import { Tradercategory } from 'src/app/shared/tradercategory.model';
//import { Tradercategory } from '../../shared/tradercategory.model';

@Component({
  selector: 'app-tradercategory-list',
  templateUrl: './tradercategory-list.component.html',
  styleUrls: ['./tradercategory-list.component.css']
})
export class TradercategoryListComponent implements OnInit {

  
  constructor(private service: TradercategoryService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }
  populateForm(tcn:Tradercategory) { 
    this.service.formData = Object.assign({}, tcn);
  }
  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deleteTraderCategory(id).subscribe(res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'TCN. Register');
      });
    }
  }

}
