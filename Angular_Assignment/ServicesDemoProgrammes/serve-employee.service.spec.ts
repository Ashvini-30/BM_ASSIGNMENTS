import { TestBed } from '@angular/core/testing';

import { ServeEmployeeService } from './serve-employee.service';

describe('ServeEmployeeService', () => {
  let service: ServeEmployeeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServeEmployeeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
